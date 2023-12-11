CREATE TABLE [kanif].[Login_Credentials]
(
    [UserId] INT IDENTITY(1,1) NOT NULL,
	[UserName] VARCHAR(10) NOT NULL UNIQUE, 
    [Password] VARCHAR(15) NOT NULL, 
    [AuthenticationKey] VARCHAR(20) NOT NULL,
    [VenderTypeId] INT NOT NULL 
    CONSTRAINT [PK_Login_Credentials] PRIMARY KEY ([UserId])
)
