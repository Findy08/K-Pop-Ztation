CREATE TABLE [dbo].[TransactionHeader] (
    [TransactionID]   INT  IDENTITY (1, 1) NOT NULL,
    [TransactionDate] DATE NOT NULL,
    [CustomerID]      INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionID] ASC),
    FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([CustomerID]) ON DELETE CASCADE ON UPDATE CASCADE
);

