CREATE TABLE [dbo].[Hakkimizdas] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL DEFAULT 0,
    [FotoUrl]  NVARCHAR (MAX) NULL,
    [Aciklama] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Hakkimizdas] PRIMARY KEY CLUSTERED ([ID] ASC)
);

