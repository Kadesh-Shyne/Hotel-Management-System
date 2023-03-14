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

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230308074920_firstDbMigration', N'6.0.14');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Bookings] (
    [BookingsId] int NOT NULL IDENTITY,
    [CustomerId] int NOT NULL,
    [RoomId] int NOT NULL,
    [BookingDate] datetime2 NOT NULL,
    [CheckInDate] datetime2 NOT NULL,
    [CheckOutDate] datetime2 NOT NULL,
    [NoOfNights] int NOT NULL,
    CONSTRAINT [PK_Bookings] PRIMARY KEY ([BookingsId])
);
GO

CREATE TABLE [CustomerDetail] (
    [CustomerId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(50) NOT NULL,
    [MiddleName] nvarchar(50) NULL,
    [LastName] nvarchar(50) NOT NULL,
    [AddressLine1] nvarchar(3) NOT NULL,
    [AddressLine2] nvarchar(50) NOT NULL,
    [City] nvarchar(50) NOT NULL,
    [State] nvarchar(50) NOT NULL,
    [PostalCode] int NOT NULL,
    [Country] nvarchar(50) NOT NULL,
    [PhoneNumber] nvarchar(11) NOT NULL,
    [EmailAddress] nvarchar(20) NULL,
    [Password] nvarchar(20) NULL,
    CONSTRAINT [PK_CustomerDetail] PRIMARY KEY ([CustomerId])
);
GO

CREATE TABLE [Employees] (
    [StaffId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [MiddleName] nvarchar(50) NULL,
    [LastName] nvarchar(50) NOT NULL,
    [AddressLine1] nvarchar(3) NOT NULL,
    [AddressLine2] nvarchar(50) NOT NULL,
    [City] nvarchar(50) NOT NULL,
    [State] nvarchar(50) NOT NULL,
    [PostalCode] int NOT NULL,
    [Country] nvarchar(50) NOT NULL,
    [PhoneNumber] nvarchar(11) NOT NULL,
    [EmailAddress] nvarchar(20) NULL,
    [Password] nvarchar(20) NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY ([StaffId])
);
GO

CREATE TABLE [Hostel] (
    [HostelId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [MiddleName] nvarchar(50) NULL,
    [LastName] nvarchar(50) NOT NULL,
    [AddressLine1] nvarchar(3) NOT NULL,
    [AddressLine2] nvarchar(50) NOT NULL,
    [PhoneNumber] nvarchar(11) NOT NULL,
    [State] nvarchar(50) NOT NULL,
    [PostalCode] int NOT NULL,
    CONSTRAINT [PK_Hostel] PRIMARY KEY ([HostelId])
);
GO

CREATE TABLE [Payments] (
    [PaymentId] int NOT NULL IDENTITY,
    [CustomerId] int NOT NULL,
    [BookingId] int NOT NULL,
    [FirstName] nvarchar(max) NULL,
    [MiddleName] nvarchar(50) NULL,
    [LastName] nvarchar(50) NOT NULL,
    [CreditCardNumber] nvarchar(20) NULL,
    [ExpiryDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Payments] PRIMARY KEY ([PaymentId])
);
GO

CREATE TABLE [Rooms] (
    [RoomId] int NOT NULL IDENTITY,
    [RoomType] nvarchar(max) NULL,
    [Image] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [HotelId] int NOT NULL,
    CONSTRAINT [PK_Rooms] PRIMARY KEY ([RoomId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230308082059_secodMigration', N'6.0.14');
GO

COMMIT;
GO

