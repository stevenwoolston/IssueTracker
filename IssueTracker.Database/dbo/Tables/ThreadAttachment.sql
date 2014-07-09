CREATE TABLE [dbo].[ThreadAttachment] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [ThreadId]     INT NOT NULL,
    [AttachmentId] INT NOT NULL,
    CONSTRAINT [PK_ThreadAttachment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ThreadAttachment_Attachment] FOREIGN KEY ([AttachmentId]) REFERENCES [dbo].[Attachment] ([Id]),
    CONSTRAINT [FK_ThreadAttachment_Thread] FOREIGN KEY ([ThreadId]) REFERENCES [dbo].[Thread] ([Id])
);

