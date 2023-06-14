CREATE TABLE [dbo].[Cart] (
    [CustomerID] INT NOT NULL,
    [AlbumID]    INT NOT NULL,
    [Qty]        INT NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC, [AlbumID] ASC),
    FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([CustomerID]) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY ([AlbumID]) REFERENCES [dbo].[Album] ([AlbumID]) ON DELETE CASCADE ON UPDATE CASCADE
);

