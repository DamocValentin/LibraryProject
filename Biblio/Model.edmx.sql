
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/12/2018 20:13:58
-- Generated from EDMX file: E:\facultate\Anul 3\Sem2\TSP.NET\ProiectEntityFramework\Biblio\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BTEST];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CarteAutor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cartes] DROP CONSTRAINT [FK_CarteAutor];
GO
IF OBJECT_ID(N'[dbo].[FK_GenCarte]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cartes] DROP CONSTRAINT [FK_GenCarte];
GO
IF OBJECT_ID(N'[dbo].[FK_ImprumutCarte]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Imprumuts] DROP CONSTRAINT [FK_ImprumutCarte];
GO
IF OBJECT_ID(N'[dbo].[FK_CititorImprumut]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Imprumuts] DROP CONSTRAINT [FK_CititorImprumut];
GO
IF OBJECT_ID(N'[dbo].[FK_ImprumutReview]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reviews] DROP CONSTRAINT [FK_ImprumutReview];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Gens]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gens];
GO
IF OBJECT_ID(N'[dbo].[Autors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autors];
GO
IF OBJECT_ID(N'[dbo].[Cartes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cartes];
GO
IF OBJECT_ID(N'[dbo].[Imprumuts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Imprumuts];
GO
IF OBJECT_ID(N'[dbo].[Cititors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cititors];
GO
IF OBJECT_ID(N'[dbo].[Reviews]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reviews];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Gens'
CREATE TABLE [dbo].[Gens] (
    [GenId] int IDENTITY(1,1) NOT NULL,
    [Descriere] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Autors'
CREATE TABLE [dbo].[Autors] (
    [AutorId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(20)  NOT NULL,
    [Prenume] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Cartes'
CREATE TABLE [dbo].[Cartes] (
    [CarteId] int IDENTITY(1,1) NOT NULL,
    [Titlu] nvarchar(50)  NOT NULL,
    [AutorId] int  NOT NULL,
    [GenId] int  NOT NULL
);
GO

-- Creating table 'Imprumuts'
CREATE TABLE [dbo].[Imprumuts] (
    [ImprumutId] int IDENTITY(1,1) NOT NULL,
    [DataImprumut] datetime  NOT NULL,
    [DataScadenta] datetime  NOT NULL,
    [DataRestituire] datetime  NULL,
    [CarteId] int  NOT NULL,
    [CititorId] int  NOT NULL
);
GO

-- Creating table 'Cititors'
CREATE TABLE [dbo].[Cititors] (
    [CititorId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [Adresa] nvarchar(50)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [Stare] smallint  NOT NULL
);
GO

-- Creating table 'Reviews'
CREATE TABLE [dbo].[Reviews] (
    [ReviewId] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [ImprumutId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [GenId] in table 'Gens'
ALTER TABLE [dbo].[Gens]
ADD CONSTRAINT [PK_Gens]
    PRIMARY KEY CLUSTERED ([GenId] ASC);
GO

-- Creating primary key on [AutorId] in table 'Autors'
ALTER TABLE [dbo].[Autors]
ADD CONSTRAINT [PK_Autors]
    PRIMARY KEY CLUSTERED ([AutorId] ASC);
GO

-- Creating primary key on [CarteId] in table 'Cartes'
ALTER TABLE [dbo].[Cartes]
ADD CONSTRAINT [PK_Cartes]
    PRIMARY KEY CLUSTERED ([CarteId] ASC);
GO

-- Creating primary key on [ImprumutId] in table 'Imprumuts'
ALTER TABLE [dbo].[Imprumuts]
ADD CONSTRAINT [PK_Imprumuts]
    PRIMARY KEY CLUSTERED ([ImprumutId] ASC);
GO

-- Creating primary key on [CititorId] in table 'Cititors'
ALTER TABLE [dbo].[Cititors]
ADD CONSTRAINT [PK_Cititors]
    PRIMARY KEY CLUSTERED ([CititorId] ASC);
GO

-- Creating primary key on [ReviewId] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [PK_Reviews]
    PRIMARY KEY CLUSTERED ([ReviewId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AutorId] in table 'Cartes'
ALTER TABLE [dbo].[Cartes]
ADD CONSTRAINT [FK_CarteAutor]
    FOREIGN KEY ([AutorId])
    REFERENCES [dbo].[Autors]
        ([AutorId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarteAutor'
CREATE INDEX [IX_FK_CarteAutor]
ON [dbo].[Cartes]
    ([AutorId]);
GO

-- Creating foreign key on [GenId] in table 'Cartes'
ALTER TABLE [dbo].[Cartes]
ADD CONSTRAINT [FK_GenCarte]
    FOREIGN KEY ([GenId])
    REFERENCES [dbo].[Gens]
        ([GenId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GenCarte'
CREATE INDEX [IX_FK_GenCarte]
ON [dbo].[Cartes]
    ([GenId]);
GO

-- Creating foreign key on [CarteId] in table 'Imprumuts'
ALTER TABLE [dbo].[Imprumuts]
ADD CONSTRAINT [FK_ImprumutCarte]
    FOREIGN KEY ([CarteId])
    REFERENCES [dbo].[Cartes]
        ([CarteId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ImprumutCarte'
CREATE INDEX [IX_FK_ImprumutCarte]
ON [dbo].[Imprumuts]
    ([CarteId]);
GO

-- Creating foreign key on [CititorId] in table 'Imprumuts'
ALTER TABLE [dbo].[Imprumuts]
ADD CONSTRAINT [FK_CititorImprumut]
    FOREIGN KEY ([CititorId])
    REFERENCES [dbo].[Cititors]
        ([CititorId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CititorImprumut'
CREATE INDEX [IX_FK_CititorImprumut]
ON [dbo].[Imprumuts]
    ([CititorId]);
GO

-- Creating foreign key on [ImprumutId] in table 'Reviews'
ALTER TABLE [dbo].[Reviews]
ADD CONSTRAINT [FK_ImprumutReview]
    FOREIGN KEY ([ImprumutId])
    REFERENCES [dbo].[Imprumuts]
        ([ImprumutId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ImprumutReview'
CREATE INDEX [IX_FK_ImprumutReview]
ON [dbo].[Reviews]
    ([ImprumutId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------