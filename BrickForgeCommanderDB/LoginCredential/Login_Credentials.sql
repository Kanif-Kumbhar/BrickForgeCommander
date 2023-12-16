CREATE TABLE [kanif].[Login_Credentials]
(
	[UserId] INT NOT NULL PRIMARY KEY, 
    [UserName] VARCHAR(20) NOT NULL, 
    [Password] VARCHAR(20) NOT NULL, 
    [AuthenticationKey] VARCHAR(25) NOT NULL
)
