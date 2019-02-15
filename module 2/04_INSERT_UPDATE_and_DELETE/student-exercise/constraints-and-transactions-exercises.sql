-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT INTO actor(first_name, last_name)
VALUES('Hampton', 'Avenue'),('Lisa', 'Byway');

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
INSERT INTO film(title, description, release_year, language_id, rental_duration, length, replacement_cost, rating)
VALUES('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, 1, 198, 10, 'PG');

		--SELECT *
		--FROM film
		--WHERE film.film_id = 1001

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
INSERT INTO film_actor (film_id, actor_id)
VALUES	(
			(SELECT film.film_id 
				FROM film 
				WHERE film.title = 'Euclidean PI'), 
			(SELECT actor.actor_id 
				FROM actor 
				WHERE actor.first_name = 'Hampton' AND actor.last_name = 'Avenue')
		) 
		,
		(
			(SELECT film.film_id
				FROM film
				WHERE film.title = 'Euclidean PI'), 
			(SELECT actor.actor_id
				FROM actor
				WHERE actor.first_name = 'Lisa' AND actor.last_name = 'Byway')
		);
	

		--SELECT actor.first_name, actor.last_name
		--FROM actor
		--JOIN film_actor ON film_actor.actor_id = actor.actor_id
		--JOIN film ON film.film_id = film_actor.film_id
		--WHERE film.title = 'Euclidean PI'

-- 4. Add Mathmagical to the category table.
INSERT INTO category(name)
VALUES ('Mathmagical');

		--SELECT film.film_id
		--FROM film
		--WHERE film.title IN ('Euclidean PI', 'EGG IGBY', 'KARATE MOON', 'RANDOM GO', 'YOUNG LANGUAGE')

		--SELECT *
		--FROM film_category
		--WHERE film_category.category_id = 17 AND film_category.film_id IN (274, 494, 714, 996, 1001)

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
INSERT INTO film_category(film_id, category_id)
VALUES    ((SELECT film.film_id
				FROM film
				WHERE film.title = 'Euclidean PI'), 
			( SELECT category.category_id
				FROM category
				WHERE category.name = 'Mathmagical'
			)),
			((SELECT film.film_id
				FROM film
				WHERE film.title = 'EGG IGBY'), 
			( SELECT category.category_id
				FROM category
				WHERE category.name = 'Mathmagical'
			)),
			((SELECT film.film_id
				FROM film
				WHERE film.title = 'KARATE MOON'), 
			( SELECT category.category_id
				FROM category
				WHERE category.name = 'Mathmagical'
			)),
			((SELECT film.film_id
				FROM film
				WHERE film.title = 'RANDOM GO'), 
			( SELECT category.category_id
				FROM category
				WHERE category.name = 'Mathmagical'
			)),
			((SELECT film.film_id
				FROM film
				WHERE film.title = 'YOUNG LANGUAGE'), 
			( SELECT category.category_id
				FROM category
				WHERE category.name = 'Mathmagical'
			));

		--SELECT *
		--FROM film
		--JOIN film_category ON film.film_id = film_category.film_id
		--JOIN category ON film_category.category_id = category.category_id
		--WHERE category.category_id = 17


-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected) 
	
		--SELECT *
		--FROM film
		--JOIN film_category ON film.film_id = film_category.film_id
		--JOIN category ON film_category.category_id = category.category_id
		--WHERE category.category_id = 17

UPDATE film SET rating = 'G'
FROM film
WHERE film.film_id IN 
	(
		SELECT film_category.film_id
		FROM film_category
		WHERE film_category.category_id = 
		(
			SELECT category.category_id
			FROM category
			WHERE category.name = 'Mathmagical'
		)
	);

-- 7. Add a copy of "Euclidean PI" to all the stores.
INSERT INTO inventory(film_id, store_id)
VALUES	(
			(SELECT film.film_id
				FROM film
				WHERE film.title = 'Euclidean PI'),
			1 
		)
		,
		(
			(SELECT film.film_id
				FROM film
				WHERE film.title = 'Euclidean PI'),
			2
		
		);

		--SELECT store.store_id
		--FROM store
		--JOIN inventory ON inventory.store_id = store.store_id
		--JOIN film ON inventory.film_id = film.film_id
		--WHERE film.title = 'Euclidean PI'
 

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
-- No, this because the movie exists as a foreign key in another table. Since the primary key is referenced in another, deleting will cause issues with referential integerity

DELETE FROM film
WHERE film.title = 'Euclidean PI';

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
-- No, this because the category exists as a foreign key in another table. Since the primary key is referenced in another table, deleting will cause issues with referential integerity

DELETE FROM category
WHERE category.name = 'Mathmagical'

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
-- No, this because the category exists as a foreign key in another table. Since the primary key is referenced in another table, deleting will cause issues with referential integerity

DELETE FROM film_category
WHERE film_category.category_id = 
	(SELECT category.category_id 
		FROM category
		WHERE category.name = 'Mathmagical');

		--SELECT film_category.category_id, film_category.film_id
		--FROM film_category
		--WHERE film_category.category_id = 17;

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>
-- We were able to delete from the category table because the reference to the primary key in the film_category table was removed. Therefore, deleting the record would not cause issues with referential integerity
-- We were not able to delete the film from the film table because the film's primary key was referenced in film_actor table as well as the inventory table

DELETE FROM category
WHERE category.category_id = 
	(
		SELECT category.category_id
		FROM category
		WHERE category.name = 'Mathmagical'
	);

DELETE FROM film
WHERE film.film_id = 
	(
		SELECT film.film_id
		FROM film
		WHERE film.title = 'Euclidean PI'
	);

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

-- As stated in the previous answer, all references in the actor_film table and the inventory table would need to be removed before the film could be deleted:

-- Delete the primary key reference in the film_actor table
DELETE FROM film_actor
WHERE film_actor.film_id = 
	(
		SELECT film.film_id
		FROM film
		WHERE film.title = 'Euclidean PI'
	);

		--SELECT *
		--FROM film_actor
		--WHERE film_actor.film_id = 
		--	(
		--		SELECT film.film_id
		--		FROM film
		--		WHERE film.title = 'Euclidean PI'
		--	);

-- Delete the primary key reference in the inventory table
DELETE FROM inventory
WHERE inventory.film_id = 
	(
		SELECT film.film_id
		FROM film
		WHERE film.title = 'Euclidean PI'
	);

		--SELECT *
		--FROM inventory
		--WHERE inventory.film_id = 
		--	(
		--		SELECT film.film_id
		--		FROM film
		--		WHERE film.title = 'Euclidean PI'
		--	);

-- Now we are able to delete the film from the film table	
DELETE FROM film
WHERE film.film_id = 
	(
		SELECT film.film_id
		FROM film
		WHERE film.title = 'Euclidean PI'
	);