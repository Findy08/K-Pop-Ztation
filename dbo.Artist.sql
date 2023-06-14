CREATE TABLE [dbo].[Artist] (
    [ArtistID]    INT          IDENTITY (1, 1) NOT NULL,
    [ArtistName]  VARCHAR (50) NOT NULL,
    [ArtistImage] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ArtistID] ASC)
);

