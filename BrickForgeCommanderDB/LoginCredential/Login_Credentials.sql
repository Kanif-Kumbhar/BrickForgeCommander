CREATE TABLE [BFC].[Login_Credentials]
(
	[UserId] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [UserName] VARCHAR(20) NOT NULL, 
    [Password] VARCHAR(20) NOT NULL, 
    [AuthenticationKey] VARCHAR(25) NOT NULL
)
