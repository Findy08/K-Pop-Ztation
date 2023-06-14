CREATE TABLE [dbo].[TransactionDetail] (
    [TransactionID] INT NOT NULL,
    [AlbumID]       INT NOT NULL,
    [Qty]           INT NOT NULL,
	PRIMARY KEY([TransactionID], [AlbumID]),
    FOREIGN KEY ([TransactionID]) REFERENCES [dbo].[TransactionHeader] ([TransactionID]) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY ([AlbumID]) REFERENCES [dbo].[Album] ([AlbumID]) ON DELETE CASCADE ON UPDATE CASCADE
);

