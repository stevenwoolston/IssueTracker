CREATE TABLE [dbo].[Thread] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (500) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [IsActive]    BIT            NOT NULL,
    [CreatedBy]   INT            NOT NULL,
    [CreatedDate] DATETIME       NOT NULL,
    [LastModBy]   INT            NOT NULL,
    [LastModDate] DATETIME       NOT NULL,
    CONSTRAINT [PK_Thread] PRIMARY KEY CLUSTERED ([Id] ASC)
);

