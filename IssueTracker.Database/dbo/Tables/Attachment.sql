CREATE TABLE [dbo].[Attachment] (
    [Id]               INT             IDENTITY (1, 1) NOT NULL,
    [OriginalTitle]    NVARCHAR (500)  NOT NULL,
    [GUID]             NVARCHAR (100)  NOT NULL,
    [AttachmentBinary] VARBINARY (MAX) NOT NULL,
    CONSTRAINT [PK_Attachment] PRIMARY KEY CLUSTERED ([Id] ASC)
);

