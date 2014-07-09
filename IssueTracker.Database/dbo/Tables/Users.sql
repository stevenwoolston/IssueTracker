CREATE TABLE [dbo].[Users] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Firstname]       NVARCHAR (50)  NOT NULL,
    [Lastname]        NVARCHAR (50)  NOT NULL,
    [EmailAddress]    NVARCHAR (200) NOT NULL,
    [IsActive]        BIT            NOT NULL,
    [WindowsUserName] NVARCHAR (100) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

