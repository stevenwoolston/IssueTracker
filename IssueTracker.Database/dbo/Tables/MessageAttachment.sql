CREATE TABLE [dbo].[MessageAttachment] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [MessageId]    INT NOT NULL,
    [AttachmentId] INT NOT NULL,
    CONSTRAINT [PK_MessageAttachment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MessageAttachment_Attachment] FOREIGN KEY ([AttachmentId]) REFERENCES [dbo].[Attachment] ([Id]),
    CONSTRAINT [FK_MessageAttachment_Message] FOREIGN KEY ([MessageId]) REFERENCES [dbo].[Message] ([Id])
);

