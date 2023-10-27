CREATE TABLE DniOtpuska (
Id int NOT NULL IDENTITY(1,1),
date_start date,
date_end date,
id_user int,
FOREIGN KEY (id_user) REFERENCES Login(Id)
);

CREATE TABLE Inform (
Id int NOT NULL IDENTITY(1,1),
dolgnost varchar(255),
telephone varchar(255),
fio varchar(255),
id_user int,
FOREIGN KEY (id_user) REFERENCES Login(Id)
);


CREATE TABLE Login (
Id int NOT NULL IDENTITY(1,1),
name varchar(255),
password varchar(255),
PRIMARY KEY (Id)
);