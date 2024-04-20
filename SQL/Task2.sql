SELECT room_number
FROM rooms
WHERE room_id NOT IN (
    SELECT room_id
    FROM bookings
    WHERE check_in_date <= GETDATE()
    AND check_out_date >= GETDATE()
);

SELECT *
FROM customers
WHERE second_name LIKE 'S%';

SELECT *
FROM bookings
WHERE customer_id = (
    SELECT customer_id
    FROM customers
    WHERE first_name = 'Аристарх'
	OR  email = 'ArStelK@gmail.com'
);

SELECT *
FROM bookings
WHERE room_id = '2';

SELECT room_number
FROM rooms
WHERE room_id NOT IN (
    SELECT room_id
    FROM bookings
    WHERE check_in_date <= '2024-05-20'
    AND check_out_date >= '2024-06-23'
);