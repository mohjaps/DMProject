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
	LastLogin DateTime Default GetDate(),
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

--Functions
--Create Function GetTokenTime(@Id Int) returns VarChar(50) As
--Begin
--	Declare @Time int
--	Declare @Seconds int
--	Declare @Minuates int
--	Declare @StringSeconds VarChar(3)
--	Declare @StringMinuates VarChar(3)
--	Select @Time = timeConsumed From Rounds Where Id = @Id
--	if @Time >= 60 
--	Begin
--		Set @Minuates = (@Time/60)
--		Set @Seconds = @Time%60 
--	End
--	Else
--	Begin
--		Set @Minuates = 0;
--		Set @Seconds = @Time
--	End
--	If @Seconds < 10 
--		Set @StringSeconds = '0'+ Convert(Varchar(3), @Seconds)
--	Else 
--		Set @StringSeconds = Convert(Varchar(3), @Seconds)
--	If @Minuates < 10 
--		Set @StringMinuates = '0'+ Convert(Varchar(3), @Minuates)
--	Else 
--		Set @StringMinuates = Convert(Varchar(3), @Minuates)
--	Return 
--	(
--		Concat(@StringMinuates, ':', @StringSeconds)
--	)
--End


--Views
--Create View ShowRounds As 
--Select Name, totalQuestions as "Number Of Questions", Concat('% ',Convert(VarChar(4), R.Score)) As "Round Score", dbo.GetTokenTime(R.Id) As "Total Time Consumed", RoundDateTime As "Round Time"
--From Players P Join Rounds R 
--On P.Username = R.PlayerUsername


