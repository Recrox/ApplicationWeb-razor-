﻿CREATE TABLE Person(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(250) NOT NULL,
	LastName VARCHAR(250) NOT NULL,
	Age INT NOT NULL,
	IsAlive BIT NOT NULL,
)