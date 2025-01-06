create database gym;

create table person (
person_id int primary key,
gender varchar(30),
passwordd varchar (40),
email varchar(40),
city varchar (40),
street varchar (40),
first_name varchar (40),
last_name varchar(40),
birthdate date,
person_type varchar(50),
CHECK (person_type IN ('staff', 'customer')));



create table staff(
staff_id int primary key,
role varchar (40) CHECK (role in ('Receptionist','Admin','Coach')),
FOREIGN KEY (staff_id) REFERENCES Person(person_id),
);


create table customer(
customer_id int primary key,
customer_type varchar(50),
FOREIGN KEY (customer_id) REFERENCES Person(person_id),
CHECK (customer_type IN ('member', 'guest'))
);


create table guest(
guest_id int primary key,
guest_source varchar(50),
foreign key (guest_id) references customer (customer_id));



create table member(
member_id  int primary key REFERENCES customer(customer_id),
membership_start_date date,
membership_end_date date,
membership_renewable bit,
membership_type varchar(50), 
membership_cost int);

create table person_phonenumber(
person_id int,
phonenumber int ,
primary key(person_id,phonenumber),
foreign key (person_id) references person(person_id));


create table coach(
coach_id int primary key,
years_of_experience int,
FOREIGN KEY (coach_id) REFERENCES staff(staff_id)
);

create table floor_coach(
floor_coach_id int primary key,
salary int,
foreign key (floor_coach_id) references coach(coach_id));


create table private_coach(
private_coach_id int primary key,
session_price int,
foreign key (private_coach_id) references coach(coach_id));



create table branch(
branch_id int primary key,
branch_name varchar(50),
city varchar(50),
street varchar(50));


create table coach_speciality(
coach_id int,
speciality varchar(50),
primary key(coach_id,speciality));


create table class (
class_id int PRIMARY KEY ,
capacity int,
class_level varchar(50));


create table class_type(
class_id int,
class_type varchar(50),
primary key (class_id,class_type));


create table timetable (
timetable_id int primary key,
next_date date,
week_day varchar(50),
start_time varchar(50),
end_time varchar(50));


create table coach_timetable(
private_coach_id int,
timetable_id int 
primary key (private_coach_id,timetable_id));


create table class_timetable(
class_id int,
timetable_id int,
primary key (class_id,timetable_id));


create table payment(
payment_id int primary key,
method varchar(50),
date_ date,
amount real);


create table customer_pay_class(
customer_id int,
class_id int,
payment_id int,
primary key (customer_id,class_id,payment_id));


create table fitness_information(
info_id int,
weight_ int,
height int,
goal_weight int,
member_id int,
primary key (member_id,info_id),
FOREIGN KEY (member_id) REFERENCES member(member_id));


create table review(
review_id int primary key,
rating int,
comment varchar(100));


create table coach_review(
coach_review_id int);


create table class_review(
class_review_id int primary key);



ALTER TABLE staff 
ADD CONSTRAINT check_role CHECK (
(role = 'Receptionist' AND staff_id BETWEEN 31 AND 34) OR
(role = 'Branch Manager' AND staff_id BETWEEN 11 AND 20) OR 
(role = 'Coach')
);?


ALTER TABLE branch ADD admin_id int;


ALTER TABLE branch
ADD CONSTRAINT fk_admin_id
FOREIGN KEY (admin_id) REFERENCES staff(staff_id);

ALTER TABLE coach_speciality
ADD CONSTRAINT fk_coach_id
FOREIGN KEY (coach_id)
REFERENCES coach(coach_id);

ALTER TABLE payment
ADD Receptionist_id int REFERENCES receptionist(receptionist_id),
customer_id int REFERENCES customer(customer_id);



ALTER TABLE class_timetable
ADD CONSTRAINT fk_timetable_id
FOREIGN KEY (timetable_id)
REFERENCES timetable(timetable_id);



ALTER TABLE class_timetable
ADD CONSTRAINT fk_class_id
FOREIGN KEY (class_id)
REFERENCES class(class_id);

ALTER TABLE coach_timetable
ADD CONSTRAINT fk_timetable_id_2
FOREIGN KEY (timetable_id)
REFERENCES timetable(timetable_id);

ALTER TABLE coach_timetable
ADD CONSTRAINT fk_timetable_id_3
FOREIGN KEY (private_coach_id)
REFERENCES private_coach(private_coach_id);

ALTER TABLE member
ADD  private_coach_id int,
Receptionist_id int;

ALTER TABLE member
ADD CONSTRAINT fk_coach FOREIGN KEY (private_coach_id) REFERENCES private_coach(private_coach_id),
CONSTRAINT fk_receptionist FOREIGN KEY (Receptionist_id) REFERENCES staff(staff_id);


ALTER TABLE class
ADD coach_id int REFERENCES coach(coach_id);

ALTER TABLE class_type
ADD CONSTRAINT fk_class_id2
FOREIGN KEY (class_id)
REFERENCES class(class_id);


ALTER TABLE customer_pay_class
ADD CONSTRAINT fk_customer_id
FOREIGN KEY (customer_id)
REFERENCES customer(customer_id);


ALTER TABLE customer_pay_class
ADD CONSTRAINT fk_class_id_2
FOREIGN KEY (class_id)
REFERENCES class(class_id);


ALTER TABLE customer_pay_class
ADD CONSTRAINT fk_payment_id
FOREIGN KEY (payment_id)
REFERENCES payment(payment_id);


alter table coach_review add coach_id int,member_id int;

ALTER TABLE coach_review
ADD CONSTRAINT fk_coach_id_2
FOREIGN KEY (coach_id)
REFERENCES coach(coach_id);


ALTER TABLE coach_review
ADD CONSTRAINT fk_member_id
FOREIGN KEY (member_id)
REFERENCES member(member_id);


ALTER TABLE coach_review
ADD CONSTRAINT fk_coach_review_id
FOREIGN KEY (coach_review_id)
REFERENCES review(review_id);


alter table class_review add class_id int ,customer_id int;

ALTER TABLE class_review
ADD CONSTRAINT fk_class_review_id
FOREIGN KEY (class_review_id)
REFERENCES review(review_id);


ALTER TABLE class_review
ADD CONSTRAINT fk_class_id_3
FOREIGN KEY (class_id)
REFERENCES class(class_id);


ALTER TABLE class_review
ADD CONSTRAINT fk_customer_id_2
FOREIGN KEY (customer_id)
REFERENCES customer(customer_id);


INSERT INTO Person (person_id, gender, passwordd, email, city, street, first_name, last_name, birthdate, person_type)
VALUES 
(1, 'M', 'pass123', 'john@example.com', 'CityA', 'StreetA', 'John', 'Doe', '1985-05-10', 'staff'),
(2, 'F', 'pass123', 'jane@example.com', 'CityB', 'StreetB', 'Jane', 'Smith', '1990-08-15', 'customer'),
(3, 'M', 'pass123', 'jim@example.com', 'CityC', 'StreetC', 'Jim', 'Brown', '1991-04-22', 'staff'),
(4, 'F', 'pass123', 'lisa@example.com', 'CityA', 'StreetD', 'Lisa', 'Davis', '1987-11-30', 'customer'),
(5, 'M', 'pass123', 'mike@example.com', 'CityB', 'StreetE', 'Mike', 'Jones', '1993-12-25', 'staff'),
(6, 'F', 'pass123', 'anna@example.com', 'CityC', 'StreetF', 'Anna', 'Garcia', '1995-03-10', 'customer'),
(7, 'M', 'pass123', 'jack@example.com', 'CityA', 'StreetG', 'Jack', 'Martinez', '1992-06-05', 'staff'),
(8, 'F', 'pass123', 'sara@example.com', 'CityB', 'StreetH', 'Sara', 'Lee', '1988-07-14', 'customer'),
(9, 'M', 'pass123', 'tom@example.com', 'CityC', 'StreetI', 'Tom', 'White', '1986-09-23', 'staff'),
(10, 'F', 'pass123', 'rose@example.com', 'CityA', 'StreetJ', 'Rose', 'Clark', '1994-02-20', 'customer'),
(11, 'F', 'Passw0rd123', 'alice.johnson@example.com', 'cityA', 'streetA', 'Alice', 'Johnson', '1990-05-14', 'staff'),
(12, 'M', 'MySecure!456', 'bob.smith@example.com', 'cityB', 'streetB', 'Bob', 'Smith', '1985-07-22', 'staff'),
(13, 'F', 'SecureMe789', 'charlotte.brown@example.com', 'cityC', 'streetC', 'Charlotte', 'Brown', '1987-03-10', 'staff'),
(14, 'M', '1234Password!', 'david.jones@example.com', 'cityD', 'streetD', 'David', 'Jones', '1992-08-17', 'staff'),
(15, 'F', 'Qwerty9876', 'emma.miller@example.com', 'cityE', 'streetE', 'Emma', 'Miller', '1995-11-05', 'staff'),
(16, 'M', 'PasswordX!123', 'frank.moore@example.com', 'cityA', 'streetF', 'Frank', 'Moore', '1989-01-29', 'staff'),
(17, 'F', 'SecurePassword@12', 'grace.taylor@example.com', 'cityA', 'streetG', 'Grace', 'Taylor', '1993-06-11', 'staff'),
(18, 'M', 'MyPass2020@', 'henry.wilson@example.com', 'cityB', 'streetH', 'Henry', 'Wilson', '1988-09-03', 'staff'),
(19, 'F', 'P@ssw0rd567', 'isla.james@example.com', 'cityC', 'streetI', 'Isla', 'James', '1991-12-21', 'staff'),
(20, 'M', 'Secure_1234', 'jack.white@example.com', 'cityC', 'streetJ', 'Jack', 'White', '1994-02-25', 'staff'),
(21, 'F', 'Password123!', 'layla.ahmed@example.com', 'cityA', 'streetA', 'Layla', 'Ahmed', '1992-03-15', 'customer'),
(22, 'M', 'SecurePass456', 'omar.khaled@example.com', 'cityA', 'streetA', 'Omar', 'Khaled', '1985-07-28', 'customer'),
(23, 'F', '12345Qwerty!', 'yasmin.hassan@example.com', 'cityB', 'streetB', 'Yasmin', 'Hassan', '1990-06-11', 'customer'),
(24, 'M', 'SimplePassword1', 'ahmed.salah@example.com', 'cityB', 'streetB', 'Ahmed', 'Salah', '1988-09-24', 'customer'),
(25, 'F', 'Password9876', 'fatima.ali@example.com', 'cityC', 'streetC', 'Fatima', 'Ali', '1993-04-30', 'customer'),
(26, 'M', '1234Secure!', 'mohamed.tariq@example.com', 'cityC', 'streetC', 'Mohamed', 'Tariq', '1991-12-19', 'customer'),
(27, 'F', 'Qwerty!7890', 'sanaa.nasser@example.com', 'cityD', 'streetD', 'Sanaa', 'Nasser', '1994-02-08', 'customer'),
(28, 'M', 'Secure#2020', 'hassan.mohamed@example.com', 'cityD', 'streetD', 'Hassan', 'Mohamed', '1987-11-22', 'customer'),
(29, 'F', 'Password!2468', 'nour.said@example.com', 'cityE', 'streetE', 'Nour', 'Said', '1989-10-12', 'customer'),
(30, 'M', 'Pass!word123', 'tamer.elgohary@example.com', 'cityE', 'streetE', 'Tamer', 'Elgohary', '1992-01-03', 'customer'),
(31, 'M', 'StaffPass123', 'faisal.abdullah@example.com', 'cityA', 'streetA', 'Faisal', 'Abdullah', '1990-04-12', 'staff'),
(32, 'F', 'Password!789', 'mariam.hassan@example.com', 'cityB', 'streetB', 'Mariam', 'Hassan', '1988-07-23', 'staff'),
(33, 'M', 'SecurePwd456', 'samir.rashid@example.com', 'cityA', 'streetA', 'Samir', 'Rashid', '1991-05-18', 'staff'),
(34, 'F', 'Qwerty!5678', 'lina.ahmed@example.com', 'cityC', 'streetC', 'Lina', 'Ahmed', '1993-11-07', 'staff');


INSERT INTO Branch (branch_id, branch_name, city, street, admin_id)
VALUES 
(1, 'Branch A', 'CityA', 'StreetA',11),
(2, 'Branch B', 'CityB', 'StreetB',12),
(3, 'Branch C', 'CityC', 'StreetC',13),
(4, 'Branch D', 'CityA', 'StreetD',14),
(5, 'Branch E', 'CityB', 'StreetE',15),
(6, 'Branch F', 'CityC', 'StreetF',16),
(7, 'Branch G', 'CityA', 'StreetG',17),
(8, 'Branch H', 'CityB', 'StreetH',18),
(9, 'Branch I', 'CityC', 'StreetI',19),
(10, 'Branch J', 'CityA', 'StreetJ',20);

INSERT INTO Class (class_id, capacity, class_level,coach_id)
VALUES 
(1, 30, 'Beginner',5),
(2, 20, 'Intermediate',5),
(3, 25, 'Advanced',3),
(4, 15, 'Beginner',3),
(5, 20, 'Intermediate',9),
(6, 30, 'Advanced',7),
(7, 25, 'Beginner',9),
(8, 20, 'Intermediate',3),
(9, 15, 'Advanced',1),
(10, 25, 'Beginner',3);
INSERT INTO Customer (customer_id, customer_type)
VALUES 
(2, 'member'),
(4, 'guest'),
(6, 'member'),
(8, 'guest'),
(10, 'member'),
(21, 'guest'),
(22, 'member'),
(23, 'member'),
(24, 'member'),
(25, 'member'),
(26, 'member'),
(27, 'member'),
(28, 'guest'),
(29, 'member'),
(30, 'member');
INSERT INTO staff (staff_id, role)
VALUES 
(1, 'coach'),
(3, 'coach'),
(5, 'coach'),
(7, 'coach'),
(9, 'coach'),
(11, 'Branch Manager'),
(12,'Branch Manager'),
(13,'Branch Manager'),
(14,'Branch Manager'),
(15,'Branch Manager'),
(16,'Branch Manager'),
(17,'Branch Manager'),
(18,'Branch Manager'),
(19,'Branch Manager'),
(20,'Branch Manager'),
(31, 'Receptionist'),
(32, 'Receptionist'),
(33, 'Receptionist'),
(34, 'Receptionist');

INSERT INTO administrator(admin_id)
VALUES 
(11),
(12),
(13),
(14),
(15),
(16),
(17),
(18),
(19),
(20);
INSERT INTO Payment (payment_id, method, date_, amount, Receptionist_id, customer_id)
VALUES 
(1, 'Cash', '2024-01-01', 100.00,31,22),
(2, 'Cash', '2024-01-02', 50.00,31,23),
(3, 'Bank Transfer', '2024-01-03', 75.00,31,24),
(4, 'Cash', '2024-01-04', 200.00,32,27),
(5, 'Cash', '2024-01-05', 150.00,32,25),
(6, 'Bank Transfer', '2024-01-06', 125.00,32,30),
(7, 'Cash', '2024-01-07', 80.00,33,29),
(8, 'Cash', '2024-01-08', 90.00,34,2),
(9, 'Cash', '2024-01-09',120.00,34,6),
(10, 'Credit Card', '2024-01-10', 160.00,34,23),
(11, 'Cash', '2024-11-01', 150.75, 31, 21),
(12, 'Bank Transfer', '2024-11-02', 85.50, 32, 22),
(13, 'Cash', '2024-11-03', 240.10, 33, 23),
(14, 'Bank Transfer', '2024-11-04', 120.00, 34, 24),
(15, 'Cash', '2024-11-05', 275.25, 31, 25),
(16, 'Bank Transfer', '2024-11-06', 199.99, 32, 26),
(17, 'Cash', '2024-11-07', 66.35, 33, 27),
(18, 'Bank Transfer', '2024-11-08', 210.00, 34, 28),
(19, 'Cash', '2024-11-09', 180.45, 31, 29),
(20, 'Bank Transfer', '2024-11-10', 105.60, 32, 30);

INSERT INTO Customer_Pay_Class (customer_id, class_id, payment_id)
VALUES 
(2, 1, 1),
(4, 2, 2),
(6, 3, 3),
(8, 4, 4),
(10, 2, 5),
(28, 6, 6),
(4, 1, 7),
(30, 8, 8),
(28, 9, 9),
(21, 10, 10);

iNSERT INTO Review (review_id, rating, comment)
VALUES 
(1, 4, 'Good experience'),
(2, 5, 'Excellent service'),
(3, 3, 'Average'),
(4, 4, 'Very good'),
(5, 5, 'Fantastic!'),
(6, 2, 'Not so great'),
(7, 4, 'Good support'),
(8, 5, 'Loved it'),
(9, 3, 'Okay service'),
(10, 5, 'Perfect!'),
(11, 5, 'Excellent service, highly recommended!'),
(12, 4, 'Very good experience, but room for improvement.'),
(13, 3, 'Average experience, could be better.'),
(14, 5, 'Absolutely loved it! Would come again.'),
(15, 2, 'Not great, excerises could be much better.'),
(16, 4, 'Good service, enjoyed the gym overall.'),
(17, 3, 'It was okay, but not as expected.'),
(18, 5, 'Amazing experience, exceeded my expectations!'),
(19, 1, 'Very disappointing, I will not return.'),
(20, 4, 'Nice atmosphere, but the equipments could be improved.');

INSERT INTO Coach (coach_id)
VALUES 
(1),
(3),
(5),
(7),
(9);
INSERT INTO receptionist(receptionist_id)
VALUES 
(31),
(32),
(33),
(34);
INSERT INTO Guest (guest_id)
VALUES 
(4),
(8),
(21),
(28);
INSERT INTO Member (member_id, membership_start_date, membership_end_date, membership_renewable, membership_type, membership_cost)
VALUES 
(2, '2024-01-01', '2024-12-31', 1, 'Standard', 1000),
(6, '2024-01-02', '2024-12-31', 1, 'Premium', 2000),
(10, '2024-01-03', '2024-12-31', 1, 'VIP', 3000),
(22, '2024-02-02', '2024-12-31', 0, 'Premium', 2000),
(23, '2024-03-01', '2024-12-31', 0, 'VIP', 3000),
(24, '2024-03-02', '2024-12-31', 0, 'Standard', 1000),
(25, '2024-04-01', '2024-12-31', 0, 'Premium', 2000),
(26, '2024-04-02', '2024-12-31', 0, 'VIP', 3000),
(27, '2024-05-01', '2024-12-31', 1, 'Standard', 1000),
(29, '2024-02-01', '2024-12-31', 0, 'Standard', 1000),
(30, '2024-02-01', '2024-12-31', 0, 'Standard', 1000);
INSERT INTO Fitness_Information (info_id, weight_, height, goal_weight, member_id)
VALUES 
(1, 70, 175, 65, 2),
(3, 60, 160, 55, 6),
(5, 90, 185, 85, 30),
(6, 68, 170, 62, 26),
(8, 72, 175, 68, 29),
(10, 66, 168, 60, 10),
(11, 70, 175, 65, 22),
(12, 60, 160, 55, 30),
(13, 90, 185, 85, 10),
(14, 68, 170, 62, 23),
(15, 72, 175, 68, 27),
(16, 66, 168, 60, 23),
(17, 75, 180, 70, 25),
(18, 80, 178, 75, 26),
(19, 85, 182, 80, 27),
(20, 78, 176, 74, 29);
INSERT INTO floor_coach (floor_coach_id, salary)
VALUES 
(1, 50000),
(3, 55000),
(5, 52000)
INSERT INTO private_coach(private_coach_id, session_price)
VALUES 
(7, 220),
(9, 250);
insert into coach_speciality (coach_id,speciality)
values
(1, 'Strength Training'),
(3, 'Cardio'),
(3, 'CrossFit'),
(5, 'Yoga'),
(5, 'Pilates'),
(7, 'CrossFit'),
(7, 'Strength'),
(9, 'pilates'),
(9, 'Dancing');
INSERT INTO class_type (class_id, class_type)
VALUES 
(1, 'Yoga'),
(2, 'Pilates'),
(3, 'CrossFit'),
(4, 'HIIT'),
(5, 'Zumba'),
(6, 'Boxing'),
(7, 'Dance'),
(8, 'Cardio'),
(9, 'Strength'),
(10, 'Cycling');
INSERT INTO timetable (timetable_id, next_date, week_day, start_time, end_time)
VALUES 
(1, '2024-01-01', 'Monday', '09:00', '10:00'),
(2, '2024-01-02', 'Tuesday', '10:00', '11:00'),
(3, '2024-01-03', 'Wednesday', '11:00', '12:00'),
(4, '2024-01-04', 'Thursday', '12:00', '13:00'),
(5, '2024-01-05', 'Friday', '13:00', '14:00'),
(6, '2024-01-06', 'Saturday', '14:00', '15:00'),
(7, '2024-01-07', 'Sunday', '15:00', '16:00'),
(8, '2024-01-08', 'Monday', '16:00', '17:00'),
(9, '2024-01-09', 'Tuesday', '17:00', '18:00'),
(10, '2024-01-10', 'Wednesday', '18:00', '19:00'),
(11, '2024-11-12', 'Monday', '09:00:00', '10:00:00'),
(12, '2024-11-13', 'Tuesday', '10:00:00', '11:00:00'),
(13, '2024-11-14', 'Wednesday', '11:00:00', '12:00:00'),
(14, '2024-11-15', 'Thursday', '12:00:00', '13:00:00'),
(15, '2024-11-16', 'Friday', '13:00:00', '14:00:00'),
(16, '2024-11-17', 'Saturday', '14:00:00', '15:00:00'),
(17, '2024-11-18', 'Sunday', '15:00:00', '16:00:00'),
(18, '2024-11-19', 'Monday', '09:00:00', '10:00:00'),
(19, '2024-11-20', 'Tuesday', '10:00:00', '11:00:00'),
(20, '2024-11-21', 'Wednesday', '11:00:00', '12:00:00');
INSERT INTO Coach_Timetable (private_coach_id, timetable_id)
VALUES 
(7, 1),
(7, 2),
(7, 3),
(7, 4),
(9, 5),
(9, 11),
(9, 13),
(9, 15),
(7, 17),
(9, 12);
INSERT INTO class_timetable (class_id, timetable_id)
VALUES 
(1, 6),
(2, 7),
(3, 8),
(4, 9),
(5, 10),
(6,16),
(7,14),
(8,18),
(9,19),
(10,20);
INSERT INTO coach_review (coach_review_id, coach_id, member_id)
VALUES 
(1, 1, 2),
(2, 3, 6),
(3, 5, 10),
(4, 7, 2),
(5, 9, 6),
(7,1,10),
(8,5,25),
(9,7,29),
(10,9,30);


INSERT INTO class_review (class_review_id, class_id, customer_id)
VALUES 
(11, 1, 2),
(12, 2, 10),
(13, 3, 22),
(14, 4, 29),
(15, 5, 6),
(16,6,27),
(17,7,30),
(18,9,10),
(19,10,4),
(20,6,28);
INSERT INTO Person_PhoneNumber (person_id, phonenumber)
VALUES 
(1, 12345678),
(2, 2345678),
(3, 3456789),
(4, 45678901),
(5, 567890185),
(6, 67890123),
(7, 78901234),
(8, 89012345),
(9, 90123456),
(10, 12345670),
(11, 12345678),
(12, 23456789),
(13, 34567890),
(14, 45678901),
(15, 56789012),
(16, 67890123),
(17, 78901234),
(18, 89012345),
(19, 90123456),
(20, 12345678),
(21, 23456789),
(22, 34567890),
(23, 45678901),
(24, 56789012),
(25, 67890123),
(26, 78901234),
(27, 89012345),
(28, 90123456),
(29, 12345678),
(30, 23456789),
(31, 34567890),
(32, 45678901),
(33, 56789012),
(34, 67890123);

UPDATE guest
SET guest_source = 
CASE 
WHEN guest_id = 4 THEN 'facebook ads'
WHEN guest_id = 8 THEN 'through friends'
WHEN guest_id = 21 THEN 'street banners'
END

UPDATE member
SET private_coach_id = 
CASE
WHEN member_id = 2 THEN 7
WHEN member_id = 6 THEN 9
WHEN member_id = 10 THEN 7
WHEN member_id = 22 THEN 9
WHEN member_id = 23 THEN 7
WHEN member_id = 24 THEN 9
WHEN member_id = 25 THEN 7
WHEN member_id = 26 THEN 9
WHEN member_id = 27 THEN 7
WHEN member_id = 29 THEN 9
WHEN member_id = 30 THEN 7
END
WHERE member_id IN (2, 6, 10, 22, 23, 24, 25, 26, 27, 29, 30)

UPDATE member
SET Receptionist_id = 
CASE
WHEN member_id = 2 THEN 31
WHEN member_id = 6 THEN 32
WHEN member_id = 10 THEN 33
WHEN member_id = 22 THEN 34
WHEN member_id = 23 THEN 31
WHEN member_id = 24 THEN 32
WHEN member_id = 25 THEN 33
WHEN member_id = 26 THEN 34
WHEN member_id = 27 THEN 31
WHEN member_id = 29 THEN 32
WHEN member_id = 30 THEN 33
END
WHERE member_id IN (2, 6, 10, 22, 23, 24, 25, 26, 27, 29, 30);

--procedure to confirm booking a class
	CREATE PROCEDURE BookClassWithPayment (
		@customer_id INT,
		@class_id INT,
		@payment_id INT
	)
	AS
	BEGIN
		
		IF NOT EXISTS (
			SELECT 1
			FROM class
			WHERE class_id = @class_id AND capacity > 0
		)
		BEGIN
			PRINT 'Booking failed: The class is full.';
			RETURN; 
		END
			BEGIN TRANSACTION;
			-- Insert the payment record into customer_pay_class table
			INSERT INTO customer_pay_class (customer_id, class_id, payment_id)
			VALUES (@customer_id, @class_id, @payment_id);

				COMMIT;
			END
	END

--procedure to add class
CREATE PROCEDURE AddNewClass
    @class_name VARCHAR(50),
    @coach_id INT,
    @timetable_id INT
AS
BEGIN
  
    INSERT INTO class (class_name, coach_id, timetable_id)
    VALUES (@class_name, @coach_id, @timetable_id);

END;

--assign coach to member
CREATE PROCEDURE assign_member_coach
    @MemberID INT,
    @CoachID INT,
AS
BEGIN
	UPDATE member
	SET private_coach_id = @CoachID
END;





--trigger to update class capacity when booking is made
CREATE TRIGGER trg_UpdateClassCapacity
ON customer_pay_class
AFTER INSERT
AS
BEGIN
    -- Update the capacity of the corresponding class
    UPDATE class
    SET capacity = capacity - 1
    FROM class
    INNER JOIN inserted i
        ON class.class_id = i.class_id
    WHERE class.capacity > 0;
END

CREATE TRIGGER trg_RenewMembership
ON member
AFTER UPDARE
AS
BEGIN
	DECLARE @duration INT=0;
	DECLArE @s date;
	DECLArE @e date;

	SELECT @e=membership_end_date,@s=membership_start_date 
	FROM inserted

	SET @duration = DATEDIFF(DAY,@e,@s)
	

	UPDATE member
	SET membership_start_date = GETDATE()+1,
	membership_end_date =DATEADD(DAY, @duration, GETDATE())
	FROM member JOIN inserted i ON i.member_id=member.member_id
	WHERE i.membership_renewable= 1 AND i.membership_end_date = GETDATE() 

END

CREATE TRIGGER [dbo].[before_insert_payment]
ON [dbo].[payment]
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @last_id INT;

    -- Get the last ID from the table
    SELECT @last_id = MAX(payment_id) FROM payment;

    -- If no records exist, start with 1
    IF @last_id IS NULL
        SET @last_id = 0;

    -- Insert the new record with an incremented ID
    INSERT INTO payment(payment_id,method,date_,amount,Receptionist_id,customer_id)
    SELECT @last_id + 1, method, GETDATE() ,amount,Receptionist_id,customer_id
    FROM inserted;
END;


CREATE TRIGGER before_insert_class
ON class
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @last_id INT;

    -- Get the last ID from the table
    SELECT @last_id = MAX(class_id) FROM class;

    -- If no records exist, start with 1
    IF @last_id IS NULL
        SET @last_id = 0;

    -- Insert the new record with an incremented ID
    INSERT INTO class(class_id,capacity,class_level,class_name,class_cost,coach_id)
    SELECT @last_id + 1, capacity, class_level ,class_name,class_cost,coach_id
    FROM inserted;
END;



