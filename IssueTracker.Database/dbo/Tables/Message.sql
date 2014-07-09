CREATE TABLE [dbo].[Message] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ThreadId]    INT            NOT NULL,
    [Title]       NVARCHAR (500) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [IsActive]    BIT            NOT NULL,
    [CreatedBy]   INT            NOT NULL,
    [CreatedDate] DATETIME       NOT NULL,
    [LastModBy]   INT            NOT NULL,
    [LastModDate] DATETIME       NOT NULL,
    CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Message_Thread] FOREIGN KEY ([ThreadId]) REFERENCES [dbo].[Thread] ([Id])
);

