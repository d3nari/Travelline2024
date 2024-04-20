IF NOT EXISTS (SELECT*FROM sysobjects WHERE name='rooms')
	CREATE TABLE dbo.rooms (
		room_id INT IDENTITY(1,1) NOT NULL,
		room_number INT NOT NULL,
		room_type NVARCHAR(50) NOT NULL,
		price_per_night MONEY NOT NULL,
		availability BIT NOT NULL,
		CONSTRAINT PK_rooms_id_room PRIMARY KEY(room_id)
	)

IF NOT EXISTS (SELECT*FROM sysobjects WHERE name='customers')
	CREATE TABLE dbo.customers (
		customer_id INT IDENTITY(1,1) NOT NULL,
		first_name NVARCHAR(50) NOT NULL,
		second_name NVARCHAR(50) NOT NULL,
		email NVARCHAR(50) NOT NULL,
		phone_number NVARCHAR(50) NOT NULL,
		CONSTRAINT PK_customers_id_customer PRIMARY KEY(customer_id)
	)

IF NOT EXISTS (SELECT*FROM sysobjects WHERE name='bookings')
	CREATE TABLE dbo.bookings (
		booking_id INT IDENTITY(1,1) NOT NULL,
		customer_id INT NOT NULL,
		room_id INT NOT NULL,
		check_in_date DATE NOT NULL,
		check_out_date DATE NOT NULL,
		CONSTRAINT PK_bookings_id_booking PRIMARY KEY(booking_id),
		CONSTRAINT FK_booking_id_customer
			FOREIGN KEY (customer_id) REFERENCES dbo.customers (customer_id),
		CONSTRAINT FK_booking_id_room
			FOREIGN KEY (room_id) REFERENCES dbo.rooms (room_id)
	)

IF NOT EXISTS (SELECT*FROM sysobjects WHERE name='facilities')
	CREATE TABLE dbo.facilities (
		facility_id INT IDENTITY(1,1) NOT NULL,
		facility_name NVARCHAR(50) NOT NULL,
		CONSTRAINT PK_facilities_id_facility PRIMARY KEY(facility_id)
	)

IF NOT EXISTS (SELECT*FROM sysobjects WHERE name='rooms_to_facilities')
	CREATE TABLE dbo.rooms_to_facilities (
		room_id INT NOT NULL,
		facility_id INT NOT NULL,

		CONSTRAINT PK_rooms_to_facilities_id_room_to_facility PRIMARY KEY(room_id, facility_id),

		CONSTRAINT FK_room_to_facilities_id_room
			FOREIGN KEY (room_id) REFERENCES dbo.rooms (room_id),
		CONSTRAINT FK_room_to_facilities_id_facility
			FOREIGN KEY (facility_id) REFERENCES dbo.facilities (facility_id)
	)

INSERT INTO dbo.rooms (room_number, room_type, price_per_night, availability)
VALUES
	(1, 'Single', 2000, 1),
	(2, 'Single', 2000, 0),
	(6, 'Single', 2000, 1),
	(10, 'Double', 4000, 1),
	(15, 'Double', 4000, 1),
	(21, 'Double', 4000, 0)

INSERT INTO dbo.customers(first_name, second_name, email, phone_number)
VALUES
	('Аристарх', 'Стрелков', 'ArStelK@gmail.com', '+7 902 103 56 78'),
	('Александр', 'Бобров', 'BobrAlek@mail.ru', '+7 862 113 46 98'),
	('Юрий', 'Шуйский', 'YurShy@mail.ru', '+7 782 123 56 11'),
	('Sanders', 'Chrisol', 'ChristEver@mail.ru', '+7 772 234 56 90')

INSERT INTO dbo.bookings(customer_id, room_id, check_in_date, check_out_date)
VALUES
	(1, 1, '2024-05-20', '2024-06-23'),
	(3, 2, '2024-10-05', '2024-11-14'),
	(2, 5, '2024-03-21', '2024-04-22'),
	(4, 4, '2024-09-12', '2024-11-26')

INSERT INTO dbo.facilities (facility_name)
VALUES
	('WiFi'),
	('Conditioner'),
	('Sauna'),
	('Hair dryer'),
	('All inclusive')

INSERT INTO dbo.rooms_to_facilities (room_id, facility_id)
VALUES
	(1,2),
	(1,3),
	(2,1),
	(2,4),
	(3,2),
	(3,3),
	(4,5),
	(5,1),
	(5,2),
	(5,4)

