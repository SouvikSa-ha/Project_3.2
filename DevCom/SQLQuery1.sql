CREATE TABLE [dbo].[Users](
	[Uid] INT IDENTITY(1,1) PRIMARY KEY,
	[Username] VARCHAR(16) UNIQUE NOT NULL,
	[FirstName] VARCHAR(20) NOT NULL,
	[LastName] VARCHAR(20) NOT NULL,
	[Email] VARCHAR(50) UNIQUE NOT NULL,
	[Password] VARCHAR(50) NOT NULL,
	[AlternativeEmail] VARCHAR(50) NULL,
	[Image] VARCHAR(100) NULL,
	[Question_2FA] VARCHAR(100) NULL,
	[Answer_2FA] VARCHAR(50) NULL,
	[VaultPassword] VARCHAR(50) NULL
)


CREATE TABLE [dbo].PersonalVault(
	[Vault_Id] INT IDENTITY(1,1) PRIMARY KEY,
	[Uid] INT NOT NULL FOREIGN KEY REFERENCES Users(Uid),
	[PlatformName] VARCHAR(50) NULL,
	[AccountMail] VARCHAR(50) NULL,
	[AccountPassword] VARCHAR(50) NULL,
	[Username] VARCHAR(50) NULL,
	[AlternativeMail] VARCHAR(50) NULL,
	[Notes] NVARCHAR(MAX) NULL
)


CREATE TABLE [dbo].[Tasks](
	[Id] int IDENTITY(100,1) NOT NULL, 
	[Task_Id] as 't'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Uid] INT FOREIGN KEY REFERENCES Users(Uid) NOT NULL,
	[Short_Description] NVARCHAR(400) NULL,
	[Creation_Time] DATETIME NOT NULL,
	[Target_Time] DATETIME NULL,
	[Status] INT NOT NULL,
	[Icon] NVARCHAR(10) NULL
 
);


CREATE TABLE [dbo].[Update_Histories](
	[Id] int IDENTITY(1,1) PRIMARY KEY, 
	[Content_Id] VARCHAR NOT NULL, 
	[Uid] INT FOREIGN KEY REFERENCES Users(Uid) NOT NULL,
	[Description] VARCHAR(150) NOT NULL,
	[Active] INT NOT NULL

);


CREATE TABLE [dbo].[Tags](
	[Tag_Id] INT PRIMARY KEY,
	[Tag] VARCHAR(50) NOT NULL
);


CREATE TABLE [dbo].[Reminders](
	[Id] INT IDENTITY(100,1) NOT NULL, 
	[Reminder_Id] as 'r'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Uid] INT FOREIGN KEY REFERENCES Users(Uid) NOT NULL,
	[Reminder_Time] VARCHAR NULL,
	[Title] VARCHAR(100) NULL,
	[Info] NVARCHAR(MAX) NULL,
	[Deadline] DATETIME NOT NULL
);


CREATE TABLE [dbo].[Notepads](
	[Id] INT IDENTITY(100,1) NOT NULL, 
	[Notepad_Id] as 'n'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Uid] INT FOREIGN KEY REFERENCES Users(Uid) NOT NULL,
	[Tag_Id] INT FOREIGN KEY REFERENCES Tags(Tag_Id) NULL,
	[Title] VARCHAR(100) NULL,
	[Icon] NVARCHAR(10) NULL,
	[Creation_Date] DATETIME NOT Null,
	[Update_Date] DATETIME NOT Null
 
);


CREATE TABLE [dbo].[Texts](
	[Id] int IDENTITY(100,1) NOT NULL, 
	[Text_Id] as 'txt'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Tag_Id] INT FOREIGN KEY REFERENCES Tags(Tag_Id) NULL,
	[Subtext_Title] VARCHAR(100) NULL,
	[Subtext_Type] INT NULL,
	[Subtext] NVARCHAR(500) NULL,
	[Text] NVARCHAR(MAX) NOT NULL
);


CREATE TABLE [dbo].[Files](
	[Id] int IDENTITY(100,1) NOT NULL, 
	[File_Id] as 'f'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Tag_Id] INT FOREIGN KEY REFERENCES Tags(Tag_Id) NULL,
	[Subtext_Title] VARCHAR(100) NULL,
	[Subtext_Type] INT NULL,
	[Subtext] NVARCHAR(500) NULL,
	[File_link] VARCHAR NOT NULL

);


CREATE TABLE [dbo].[Audios](
	[Id] int IDENTITY(100,1) NOT NULL, 
	[Audio_Id] as 'a'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Tag_Id] INT FOREIGN KEY REFERENCES Tags(Tag_Id) NULL,
	[Subtext_Title] VARCHAR(100) NULL,
	[Subtext_Type] INT NULL,
	[Subtext] NVARCHAR(500) NULL,
	[Audio_link] VARCHAR NOT NULL

);


CREATE TABLE [dbo].[Canvases](
	[Id] int IDENTITY(100,1) NOT NULL, 
	[Canvas_Id] as 'c'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Tag_Id] INT FOREIGN KEY REFERENCES Tags(Tag_Id) NULL,
	[Subtext_Title] VARCHAR(100) NULL,
	[Subtext_Type] INT NULL,
	[Subtext] NVARCHAR(500) NULL,
	[Canvas_link] VARCHAR NOT NULL

);


CREATE TABLE [dbo].[Images](
	[Id] int IDENTITY(100,1) NOT NULL, 
	[Image_Id] as 'i'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Tag_Id] INT FOREIGN KEY REFERENCES Tags(Tag_Id) NULL,
	[Subtext_Title] VARCHAR(100) NULL,
	[Subtext_Type] INT NULL,
	[Subtext] NVARCHAR(500) NULL,
	[Image_link] VARCHAR NOT NULL

);


CREATE TABLE [dbo].[Videos](
	[Id] INT IDENTITY(100,1) NOT NULL, 
	[Video_Id] as 'v'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Tag_Id] INT FOREIGN KEY REFERENCES Tags(Tag_Id) NULL,
	[Subtext_Title] VARCHAR(100) NULL,
	[Subtext_Type] INT NULL,
	[Subtext] NVARCHAR(500) NULL,
	[Video_link] VARCHAR NOT NULL
);


CREATE TABLE [dbo].[NoteContents](
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[Content_Id] VARCHAR NOT NULL, 
	[Notepad_Id] VARCHAR(11) FOREIGN KEY REFERENCES Notepads(Notepad_Id) NOT NULL
)


CREATE TABLE [dbo].[Visual_Boards](
	[Id] INT IDENTITY(100,1) NOT NULL, 
	[Board_Id] as 'b'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Uid] INT FOREIGN KEY REFERENCES Users(Uid) NOT NULL,
	[Tag_Id] INT FOREIGN KEY REFERENCES Tags(Tag_Id) NULL
);


CREATE TABLE [dbo].[Workflow_Designs](
	[Id] int IDENTITY(100,1) NOT NULL, 
	[Workflow_Id] as 'w'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Data] VARCHAR NOT NULL
);


CREATE TABLE [dbo].[UI_Designs](
	[Id] int IDENTITY(100,1) NOT NULL, 
	[UI_Id] as 'u'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Data] VARCHAR NOT NULL


);


CREATE TABLE [dbo].[Color_Palletes](
	[Id] int IDENTITY(100,1) NOT NULL, 
	[Pallete_Id] as 'p'+Cast(Id as Varchar(10)) PERSISTED PRIMARY KEY, 
	[Data] VARCHAR NOT NULL
);


CREATE TABLE [dbo].[Collaboration](
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
	[Board_Id] VARCHAR(11) FOREIGN KEY REFERENCES Visual_Boards(Board_Id) NOT NULL, 
	[Uid] INT FOREIGN KEY REFERENCES Users(Uid) NOT NULL,
	[Permission] INT NOT NULL
);


CREATE TABLE [dbo].[BoardComponents](
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[Content_Id] VARCHAR NOT NULL, 
	[Board_Id] VARCHAR(11) FOREIGN KEY REFERENCES Visual_Boards(Board_Id) NOT NULL,
	[PositionX] INT NOT NULL,
	[PositionY] INT NOT NULL
)





