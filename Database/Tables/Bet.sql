CREATE TABLE [dbo].[Bet]
(
	[BetId] INT NOT NULL PRIMARY KEY, 
    [BirthDate] DATETIMEOFFSET NULL, 
    [Weight] FLOAT NULL, 
    [IsMale] BIT NULL
)
