Create Database FinalProejct
Go 
Create Table Admins
(
	Id Int Identity Primary Key,
	Username VarChar(50) Not Null,
	Password VarChar(50) Not Null
)

Create Table Players
(
	Id Int Identity Primary Key,
	Name VarChar(50) Not Null,
	Age Int Not Null,
	Score Int,
	LastLogin DateTime
)

Create Table Rounds
(
	Id Int Identity Primary Key,
	PlayerId Int,
	Score Int,
	RoundDateTime DateTime Default GetDate(),
	Constraint FK_Players_Rounds Foreign Key (PlayerId) References Players(Id)
)