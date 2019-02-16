USE master;
GO

IF EXISTS(select * from sys.databases where name='ProjectOrganizer')
DROP DATABASE ProjectOrganizer;
GO

CREATE DATABASE ProjectOrganizer;
GO

USE ProjectOrganizer;
GO

BEGIN TRANSACTION;

CREATE TABLE department(
	number INT IDENTITY(1000, 1) NOT NULL,
	name VARCHAR(64) NOT NULL UNIQUE,
	CONSTRAINT pk_department PRIMARY KEY (number)
);

CREATE TABLE project(
	number INT IDENTITY NOT NULL,
	name VARCHAR(64) NOT NULL,
	startdate DATETIME NOT NULL,
	CONSTRAINT pk_project PRIMARY KEY (number)
);

-- An employee must have a number, firstname, lastname, gender, date of birth, date of hire, a single department. An employee can be added to a project	
CREATE TABLE employee(
	number INT IDENTITY(1000, 1),
	firstname VARCHAR(64) NOT NULL,
	lastname VARCHAR(64) NOT NULL,
	gender VARCHAR(1) NOT NULL,
	dateofbirth DATE NOT NULL,
	dateofhire DATETIME NOT NULL,
	department_number int NOT NULL,
	CONSTRAINT pk_employee PRIMARY KEY (number),
	CONSTRAINT employee_gender_check CHECK(gender IN ('M', 'F', 'O')),
	CONSTRAINT employee_dateofbirth_check CHECK(dateofbirth <= GETDATE()),
	CONSTRAINT fk_employee_department FOREIGN KEY (department_number) REFERENCES department(number)
);

-- An employee can have zero to many projects and a project can have zero to many employees (as well as departments)
CREATE TABLE employee_project(
	employee_number int NOT NULL,
	project_number int NOT NULL,
	CONSTRAINT pk_employee_project PRIMARY KEY (employee_number, project_number),
	CONSTRAINT fk_employee_project_employee FOREIGN KEY (employee_number) REFERENCES employee(number),
	CONSTRAINT fk_employee_project_project FOREIGN KEY (project_number) REFERENCES project(number)
);

INSERT INTO department(name)
VALUES ('Financial'),('Information Technology'),('Maintanence');

INSERT INTO project(name, startdate)
VALUES  ('Design new financial stuff', '10/09/2018'),
		('Spring clean', '01/20/2019'),
		('Create new CMS', '10/20/2019'),
		('Year end books', '09/01/2019');

INSERT INTO employee(firstname, lastname, gender, dateofbirth, dateofhire, department_number)
VALUES  ('Ben', 'Loper', 'M', '1/05/1990', '10/1/2018', 1001),
		('John', 'Loper', 'M', '2/16/1980', '12/01/2019', 1000),
		('Frank', 'Franky', 'O', '5/9/1995', '10/1/2010', 1002),
		('Bill', 'Waldo', 'F', '6/1/1980', '11/10/2000', 1002),
		('John', 'Wonderland', 'M', '9/9/1965', '05/30/2016', 1000),
		('Frodo', 'Baggins', 'O', '5/9/1995', '10/1/2010', 1001),
		('Lisa', 'Walton', 'F', '7/11/1993', '8/8/1980', 1002),
		('Samwise', 'Gamgee', 'M', '2/28/2011', '9/7/2019', 1000);

INSERT INTO employee_project(employee_number, project_number)
VALUES (
			(SELECT employee.number
			 FROM employee
			 WHERE employee.firstname = 'Ben' AND employee.lastname = 'Loper'),
			(SELECT project.number
			 FROM project
			 WHERE project.name = 'Design new financial stuff')
		)
		,
		(
			(SELECT employee.number
			 FROM employee
			 WHERE employee.firstname = 'John' AND employee.lastname = 'Wonderland'),
			(SELECT project.number
			 FROM project
			 WHERE project.name = 'Design new financial stuff')
		)
		,
		(
			(SELECT employee.number
			 FROM employee
			 WHERE employee.firstname = 'John' AND employee.lastname = 'Loper'),
			(SELECT project.number
			 FROM project
			 WHERE project.name = 'Year end books')
		)
		,
		(
			(SELECT employee.number
			 FROM employee
			 WHERE employee.firstname = 'Frank' AND employee.lastname = 'Franky'),
			(SELECT project.number
			 FROM project
			 WHERE project.name = 'Spring clean')
		)
		,
		(
			(SELECT employee.number
			 FROM employee
			 WHERE employee.firstname = 'Lisa' AND employee.lastname = 'Walton'),
			(SELECT project.number
			 FROM project
			 WHERE project.name = 'Create new CMS')
		)
		,
		(
			(SELECT employee.number
			 FROM employee
			 WHERE employee.firstname = 'Ben' AND employee.lastname = 'Loper'),
			(SELECT project.number
			 FROM project
			 WHERE project.name = 'Create new CMS')
		)
		,
		(
			(SELECT employee.number
			 FROM employee
			 WHERE employee.firstname = 'John' AND employee.lastname = 'Wonderland'),
			(SELECT project.number
			 FROM project
			 WHERE project.name = 'Spring clean')
		);


COMMIT TRANSACTION;
