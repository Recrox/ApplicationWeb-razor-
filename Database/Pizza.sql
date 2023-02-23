CREATE TABLE Pizza (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name varchar(250) NOT NULL,
	Price Decimal NOT NULL,
	Calories Decimal NOT NULL,
	GrandFormat BIT NOT NULL,
)