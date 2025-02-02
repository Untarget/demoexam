SET DATEFORMAT ymd;
CREATE TABLE Users(
    Login       VARCHAR(50) PRIMARY KEY,
    Password    VARCHAR(50),
    Role        TINYINT
);
CREATE TABLE Room(
    Id          INT PRIMARY KEY,
    Type        VARCHAR(100),
    Floor       TINYINT,
    Status      VARCHAR(50) DEFAULT 'Чистый',
    Money       INT
);
CREATE TABLE RoomReservation(
    Id          INT PRIMARY KEY IDENTITY,
    RoomId      INT,
    Fdate       DATE,
    Ldate       DATE,
    ClientFname VARCHAR(300),
    Guests INT DEFAULT 1,
    FOREIGN KEY (RoomId) REFERENCES Room (Id),
);
CREATE TABLE Employee(
    Id          INT PRIMARY KEY,
    Fname       VARCHAR(300)
);
CREATE TABLE CleaningCalendar(
    Id          INT PRIMARY KEY IDENTITY,
    RoomId      INT,
    EmployeeId  INT,
    Day         DATE,
    Time        VARCHAR(10),
    Status      VARCHAR(50),
    FOREIGN KEY (RoomId) REFERENCES Room (Id),
    FOREIGN KEY (EmployeeId) REFERENCES Employee (Id),
);
Create Table Analytic(
    Id INT PRIMARY KEY IDENTITY,
    RoomId INT,
    Guests INT,
    Money INT,
    days INT,
    Day DATE,
    FOREIGN KEY (RoomId) REFERENCES Room (Id),
)
INSERT INTO Users VALUES ('Administrator', '123123', 1), ('Owner', 'qwerty', 2);
INSERT Into Room VALUES ('101', 'Одноместный стандарт', '1', 'Чистый', 5000);
INSERT Into Room VALUES ('102', 'Одноместный стандарт', '1', 'Чистый', 5000);
INSERT Into Room VALUES ('103', 'Одноместный эконом', '1', 'Чистый', 5000);
INSERT Into Room VALUES ('104', 'Одноместный эконом', '1', 'Чистый', 5000);
INSERT Into Room VALUES ('105', 'Одноместный стандарт', '1', 'Чистый', 5000);
INSERT Into Room VALUES ('106', 'Стандарт двухместный с 2 раздельными кроватями', '1', 'Чистый', 7000);
INSERT Into Room VALUES ('107', 'Стандарт двухместный с 2 раздельными кроватями', '1', 'Чистый', 7000);
INSERT Into Room VALUES ('108', 'Эконом двухместный с 2 раздельными кроватями', '1', 'Чистый', 7000);
INSERT Into Room VALUES ('109', 'Эконом двухместный с 2 раздельными кроватями', '1', 'Чистый', 7000);
INSERT Into Room VALUES ('110', '3-местный бюджет', '1', 'Чистый', 7000);
INSERT Into Room VALUES ('201', 'Бизнес с 1 или 2 кроватями', '2', 'Чистый', 7000);
INSERT Into Room VALUES ('202', 'Бизнес с 1 или 2 кроватями', '2', 'Чистый', 7000);
INSERT Into Room VALUES ('203', 'Бизнес с 1 или 2 кроватями', '2', 'Чистый', 7000);
INSERT Into Room VALUES ('204', 'Двухкомнатный двухместный стандарт с 1 или 2 кроватями', '2', 'Назначен к уборке', 7000);
INSERT Into Room VALUES ('205', 'Двухкомнатный двухместный стандарт с 1 или 2 кроватями', '2', 'Чистый', 7000);
INSERT Into Room VALUES ('206', 'Двухкомнатный двухместный стандарт с 1 или 2 кроватями', '2', 'Чистый', 7000);
INSERT Into Room VALUES ('207', 'Одноместный стандарт', '2', 'Чистый', 7000);
INSERT Into Room VALUES ('208', 'Одноместный стандарт', '2', 'Чистый', 7000);
INSERT Into Room VALUES ('209', 'Одноместный стандарт', '2', 'Чистый', 7000);
INSERT Into Room VALUES ('301', 'Студия', '3', 'Чистый', 7000);
INSERT Into Room VALUES ('302', 'Студия', '3', 'Чистый', 7000);
INSERT Into Room VALUES ('303', 'Студия', '3', 'Чистый', 7000);
INSERT Into Room VALUES ('304', 'Люкс с 2 двуспальными кроватями', '3', 'Чистый', 7000);
INSERT Into Room VALUES ('305', 'Люкс с 2 двуспальными кроватями', '3', 'Чистый', 7000);
INSERT Into Room VALUES ('306', 'Люкс с 2 двуспальными кроватями', '3', 'Чистый', 7000);
INSERT INTO Employee VALUES (1, 'Иванов Иван Иванович');
INSERT INTO Employee VALUES (2, 'Дмитриев Дмитрий Дмитриевич');
INSERT INTO Employee VALUES (3, 'Александрова Александра Александровна');
INSERT INTO Employee VALUES (4, 'Артемьев Артем Артемович');
INSERT INTO Employee VALUES (5, 'Евгеньев Евгений Евгеньевич');
INSERT INTO RoomReservation (RoomId, ClientFname, Fdate, Ldate, Guests) VALUES (101, 'Шевченко Ольга Викторовна', '14.02.2025', '02.03.2025', 1),
(104, 'Семеняка Юрий Геннадьевич', '23.02.2025', '02.02.2025', 1),
(105, 'Савельев Олег Иванович', '01.03.2025', '07.03.2025', 1),
(107, 'Бунин Эдуард Михайлович', '27.02.2025', '22.04.2025', 1),
(107, 'Бахшиев Павел Иннокентьевич', '24.02.2025', '17.03.2025', 1 ),
(108, 'Тюренкова Наталья Сергеевна', '15.02.2025', '20.03.2025', 1 ),
(109, 'Любяшева Галина Аркадьевна', '27.02.2025', '12.03.2025', 1 ),
(110, 'Александров Петр Константинович', '14.02.2025', '02.02.2025', 1 ),
(201, 'Мазалова Ольга Николаевна', '24.02.2025', '17.03.2025', 1 ),
(203, 'Лапшин Виктор Романович', '25.02.2025', '07.03.2025', 1 ),
(205, 'Гусев Семен Петрович', '01.03.2025', '04.03.2025', 1 ),
(206, 'Гладилина Вера Михайловна', '02.02.2025', '02.02.2025', 1 ),
(207, 'Масюк Динара Викторовна', '25.02.2025', '04.03.2025', 1 ),
(208, 'Лукин Илья Федорович', '25.02.2025', '04.03.2025', 1 ),
(304, 'Филь Марина Федоровна', '28.02.2025', '15.03.2025', 1 ),
(102, 'Мазалова Ирина Львовна', '28.02.2025', '15.03.2025', 1),
(209, 'Петров Станислав Игоревич', '27.02.2025', '28.02.2025', 1),
(306, 'Михайлов Игорь Вадимович', '11.02.2025', '28.02.2025', 1);
