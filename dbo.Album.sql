CREATE TABLE [dbo].[Album] (
    [AlbumID]          INT           IDENTITY (1, 1) NOT NULL,
    [ArtistID]         INT           NOT NULL,
    [AlbumName]        VARCHAR (50)  NOT NULL,
    [AlbumImage]       VARCHAR (50)  NOT NULL,
    [AlbumPrice]       INT           NOT NULL,
    [AlbumStock]       INT           NOT NULL,
    [AlbumDescription] VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([AlbumID] ASC),
    FOREIGN KEY ([ArtistID]) REFERENCES [dbo].[Artist] ([ArtistID]) ON DELETE CASCADE ON UPDATE CASCADE
);

