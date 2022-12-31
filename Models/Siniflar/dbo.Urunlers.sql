CREATE TABLE [dbo].[Urunlers] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [Baslik]    NVARCHAR (MAX) NULL,
    [Tarih]     DATETIME2 (7)  NULL,
    [Aciklama]  NVARCHAR (MAX) NULL,
    [UrunImage] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Urunlers] PRIMARY KEY CLUSTERED ([ID] ASC)
);

