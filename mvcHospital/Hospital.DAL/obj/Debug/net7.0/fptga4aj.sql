IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Doctors] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Specialization] nvarchar(max) NOT NULL,
    [Salary] decimal(18,2) NOT NULL,
    [PerformanceRate] int NOT NULL,
    CONSTRAINT [PK_Doctors] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230612002906_initial_migration', N'7.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230612004044_data', N'7.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'PerformanceRate', N'Salary', N'Specialization') AND [object_id] = OBJECT_ID(N'[Doctors]'))
    SET IDENTITY_INSERT [Doctors] ON;
INSERT INTO [Doctors] ([Id], [Name], [PerformanceRate], [Salary], [Specialization])
VALUES ('15c9c9c8-b251-40b2-8c84-7f9ab5fa0f2a', N'Ahmed', 2, 2000.0, N'aaa'),
('75822bee-c0c3-412d-b378-d22d9f0279bc', N'Ali', 3, 3000.0, N'aaa'),
('b449274c-b096-47d5-a48f-6bfee60b5d06', N'Mostafa', 4, 4000.0, N'aaa'),
('bd6f419e-b227-4527-924a-b6bdf66a5247', N'Mohamed', 5, 5000.0, N'aaa'),
('bff53872-8091-4979-8464-91fb0e9c820b', N'Eslam', 1, 1000.0, N'aaa'),
('f2281eaf-e5fe-470c-a0e1-3da8d1050081', N'Sally', 6, 6000.0, N'aaa');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'PerformanceRate', N'Salary', N'Specialization') AND [object_id] = OBJECT_ID(N'[Doctors]'))
    SET IDENTITY_INSERT [Doctors] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230612004632_addingData', N'7.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [Doctors]
WHERE [Id] = '15c9c9c8-b251-40b2-8c84-7f9ab5fa0f2a';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Doctors]
WHERE [Id] = '75822bee-c0c3-412d-b378-d22d9f0279bc';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Doctors]
WHERE [Id] = 'b449274c-b096-47d5-a48f-6bfee60b5d06';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Doctors]
WHERE [Id] = 'bd6f419e-b227-4527-924a-b6bdf66a5247';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Doctors]
WHERE [Id] = 'bff53872-8091-4979-8464-91fb0e9c820b';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Doctors]
WHERE [Id] = 'f2281eaf-e5fe-470c-a0e1-3da8d1050081';
SELECT @@ROWCOUNT;

GO

CREATE TABLE [Issues] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Issues] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Patients] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [DoctorId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Patients] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Patients_Doctors_DoctorId] FOREIGN KEY ([DoctorId]) REFERENCES [Doctors] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [IssuePatient] (
    [IssuesId] uniqueidentifier NOT NULL,
    [PatientsId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_IssuePatient] PRIMARY KEY ([IssuesId], [PatientsId]),
    CONSTRAINT [FK_IssuePatient_Issues_IssuesId] FOREIGN KEY ([IssuesId]) REFERENCES [Issues] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_IssuePatient_Patients_PatientsId] FOREIGN KEY ([PatientsId]) REFERENCES [Patients] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'PerformanceRate', N'Salary', N'Specialization') AND [object_id] = OBJECT_ID(N'[Doctors]'))
    SET IDENTITY_INSERT [Doctors] ON;
INSERT INTO [Doctors] ([Id], [Name], [PerformanceRate], [Salary], [Specialization])
VALUES ('0cbcc2be-4146-42d3-8de2-b8ac2e7b3645', N'Eslam', 1, 1000.0, N'aaa'),
('3dc7e704-1a3d-4171-b538-faa7ab9e0d16', N'Mohamed', 5, 5000.0, N'aaa'),
('73f5e7bf-733d-4fca-b1da-e57f9f2e5ebe', N'Ali', 3, 3000.0, N'aaa'),
('7e6bf869-97c5-4184-b52b-dd8c279c5425', N'Sally', 6, 6000.0, N'aaa'),
('d0d2ea61-1059-4d49-a4b2-e1463df89dcc', N'Mostafa', 4, 4000.0, N'aaa'),
('e264de40-97e7-4a01-93f9-e02882a950c6', N'Ahmed', 2, 2000.0, N'aaa');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'PerformanceRate', N'Salary', N'Specialization') AND [object_id] = OBJECT_ID(N'[Doctors]'))
    SET IDENTITY_INSERT [Doctors] OFF;
GO

CREATE INDEX [IX_IssuePatient_PatientsId] ON [IssuePatient] ([PatientsId]);
GO

CREATE INDEX [IX_Patients_DoctorId] ON [Patients] ([DoctorId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230612041457_issuesMigration', N'7.0.5');
GO

COMMIT;
GO

