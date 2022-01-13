Create Database FinalProejct
Go 
Create Table Admins
(
	Username VarChar(50) Primary Key,
	Password VarChar(50) Not Null,
)

Create Table Players
(
	Username VarChar(50) Primary Key,
	Name VarChar(50) Not Null,
	Age Int Not Null,
	Score Int Default 0,
	LastLogin DateTime Default '0001, 01, 01',
)

Create Table Rounds
(
	Id Int Identity Primary Key,
	PlayerUsername VarChar(50),
	totalQuestions int, 
	solvedQuestions int, 
	selectedTables VarChar(100), 
	timeConsumed int, 
	correct int, 
	wrong int, 
	Score int, 
	RoundDateTime DateTime Default GetDate(),
	Constraint FK_Players_Rounds Foreign Key (PlayerUsername) References Players(Username)
)
