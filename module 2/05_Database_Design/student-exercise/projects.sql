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
	id INT IDENTITY NOT NULL,
	number VARCHAR(64) NOT NULL UNIQUE,
	name VARCHAR(64) NOT NULL UNIQUE,
	CONSTRAINT pk_department PRIMARY KEY (id)
);

CREATE TABLE project(
	id INT IDENTITY NOT NULL,
	number VARCHAR(64) NOT NULL UNIQUE,
	name VARCHAR(64) NOT NULL,
	startdate DATETIME NOT NULL,
	CONSTRAINT pk_project PRIMARY KEY (id)
);

-- A department can have many projects and a project can have many deparments
CREATE TABLE department_project(
	department_id INT NOT NULL,
	project_id INT NOT NULL,
	CONSTRAINT pk_deparment_project PRIMARY KEY (department_id, project_id),
	CONSTRAINT fk_departmentproject_project FOREIGN KEY (project_id) REFERENCES project(id),
	CONSTRAINT fk_departmentproject_department FOREIGN KEY (department_id) REFERENCES department(id)
);

-- An employee must have a number, firstname, lastname, gender, date of birth, date of hire, and a single department
CREATE TABLE employee(
	id INT IDENTITY NOT NULL,
	number VARCHAR(64) NOT NULL UNIQUE,
	firstname VARCHAR(64) NOT NULL,
	lastname VARCHAR(64) NOT NULL,
	gender BIT NOT NULL,
	dateofbirth DATE NOT NULL,
	dateofhire DATETIME NOT NULL,
	department_id int NOT NULL,

	CONSTRAINT pk_employee PRIMARY KEY (id),
	CONSTRAINT employee_gender_check CHECK(gender IN ('M', 'F', 'O')),
	CONSTRAINT employee_dateofhire_check CHECK(dateofhire <= GETDATE()),
	CONSTRAINT employee_dateofbirth_check CHECK(dateofbirth <= GETDATE()),
	CONSTRAINT fk_employee_department FOREIGN KEY (department_id) REFERENCES department(id)
);

INSERT INTO department(number, name)
VALUES (1234, 'Finances'),(1235, 'Information Technology'),(1236, 'Maintanence');

COMMIT TRANSACTION;