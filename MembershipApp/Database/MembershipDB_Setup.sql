/* ============================================================
   MembershipDB — Full database setup script
   Target: SQL Server 2005 / 2008+ compatible
   Run in SSMS against a blank DB context (master) as sysadmin
   ============================================================ */

IF DB_ID('MembershipDB') IS NULL
BEGIN
    CREATE DATABASE MembershipDB;
END
GO

USE MembershipDB;
GO

/* -------------------- TABLES -------------------- */

IF OBJECT_ID('dbo.Users','U') IS NOT NULL DROP TABLE dbo.Users;
CREATE TABLE dbo.Users (
    UserId       INT IDENTITY(1,1) PRIMARY KEY,
    Username     NVARCHAR(50)  NOT NULL UNIQUE,
    Password     NVARCHAR(100) NOT NULL,
    Role         NVARCHAR(20)  NOT NULL DEFAULT('User'),
    IsActive     BIT           NOT NULL DEFAULT(1),
    CreatedOn    DATETIME      NOT NULL DEFAULT(GETDATE())
);
GO

IF OBJECT_ID('dbo.States','U') IS NOT NULL DROP TABLE dbo.States;
CREATE TABLE dbo.States (
    StateId      INT IDENTITY(1,1) PRIMARY KEY,
    StateName    NVARCHAR(100) NOT NULL UNIQUE
);
GO

IF OBJECT_ID('dbo.MemberTypes','U') IS NOT NULL DROP TABLE dbo.MemberTypes;
CREATE TABLE dbo.MemberTypes (
    MemberTypeId   INT IDENTITY(1,1) PRIMARY KEY,
    MemberTypeName NVARCHAR(100) NOT NULL UNIQUE
);
GO

IF OBJECT_ID('dbo.Members','U') IS NOT NULL DROP TABLE dbo.Members;
CREATE TABLE dbo.Members (
    MemberId          INT IDENTITY(1,1) PRIMARY KEY,
    StateId           INT           NOT NULL,
    MemberTypeId      INT           NOT NULL,
    MemberNumber      NVARCHAR(50)  NULL,
    ApplicationNo     NVARCHAR(50)  NULL,
    MemberName        NVARCHAR(200) NOT NULL,
    AddressLine1      NVARCHAR(200) NULL,
    AddressLine2      NVARCHAR(200) NULL,
    AddressLine3      NVARCHAR(200) NULL,
    Pincode           NVARCHAR(10)  NULL,
    MobileNo          NVARCHAR(15)  NULL,
    AadharNumber      NVARCHAR(20)  NULL,
    DOB               DATE          NULL,
    Gender            NVARCHAR(10)  NULL,
    Profession        NVARCHAR(100) NULL,
    RegisteredThrough NVARCHAR(50)  NULL,
    RegisteredOn      DATE          NULL,
    CreatedOn         DATETIME      NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Members_State      FOREIGN KEY (StateId)      REFERENCES dbo.States(StateId),
    CONSTRAINT FK_Members_MemberType FOREIGN KEY (MemberTypeId) REFERENCES dbo.MemberTypes(MemberTypeId)
);
GO

IF OBJECT_ID('dbo.Renewals','U') IS NOT NULL DROP TABLE dbo.Renewals;
CREATE TABLE dbo.Renewals (
    RenewalId     INT IDENTITY(1,1) PRIMARY KEY,
    StateId       INT             NOT NULL,
    MemberTypeId  INT             NOT NULL,
    MemberNumber  NVARCHAR(50)    NOT NULL,
    MemberName    NVARCHAR(200)   NULL,
    ReceiptType   NVARCHAR(50)    NULL,
    ReceiptNo     NVARCHAR(50)    NULL,
    ReceiptDate   DATE            NULL,
    Amount        DECIMAL(18,2)   NOT NULL DEFAULT(0),
    CreatedOn     DATETIME        NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Renewals_State      FOREIGN KEY (StateId)      REFERENCES dbo.States(StateId),
    CONSTRAINT FK_Renewals_MemberType FOREIGN KEY (MemberTypeId) REFERENCES dbo.MemberTypes(MemberTypeId)
);
GO

/* -------------------- SEED DATA -------------------- */

INSERT INTO dbo.Users (Username, Password, Role) VALUES
('admin', 'admin123', 'Administrator'),
('user',  'user123',  'User');

INSERT INTO dbo.States (StateName) VALUES
('Tamil Nadu'),('Kerala'),('Karnataka'),('Andhra Pradesh'),
('Telangana'),('Maharashtra'),('Gujarat'),('Delhi'),('Punjab'),('West Bengal');

INSERT INTO dbo.MemberTypes (MemberTypeName) VALUES
('Life Member'),('Annual Member'),('Associate Member'),('Honorary Member'),('Student Member');

INSERT INTO dbo.Members
    (StateId, MemberTypeId, MemberNumber, ApplicationNo, MemberName,
     AddressLine1, AddressLine2, AddressLine3, Pincode, MobileNo,
     AadharNumber, DOB, Gender, Profession, RegisteredThrough, RegisteredOn)
VALUES
(1,1,'TN-L-001','APP-1001','Rajesh Kumar','12 Anna Salai','T Nagar','Chennai','600017','9876543210','123412341234','1980-05-15','Male','Engineer','Online','2023-01-10'),
(1,2,'TN-A-002','APP-1002','Priya Ramakrishnan','45 Gandhi Road','Mylapore','Chennai','600004','9876543211','123412341235','1990-08-22','Female','Doctor','Agent','2023-03-15'),
(2,1,'KL-L-001','APP-1003','Anoop Menon','Panambilly Nagar','Kochi','Ernakulam','682036','9876543212','123412341236','1975-11-30','Male','Businessman','Branch Office','2022-12-05'),
(3,3,'KA-AS-001','APP-1004','Lakshmi Nair','MG Road','Indiranagar','Bangalore','560001','9876543213','123412341237','1985-02-18','Female','Teacher','Referral','2023-06-20'),
(6,1,'MH-L-001','APP-1005','Amit Shah','Linking Road','Bandra West','Mumbai','400050','9876543214','123412341238','1978-09-12','Male','Architect','Online','2023-04-08');

INSERT INTO dbo.Renewals
    (StateId, MemberTypeId, MemberNumber, MemberName, ReceiptType, ReceiptNo, ReceiptDate, Amount)
VALUES
(1,1,'TN-L-001','Rajesh Kumar','Online Transfer','RCP-2024-001','2024-01-10',5000.00),
(1,2,'TN-A-002','Priya Ramakrishnan','Cash','RCP-2024-002','2024-03-15',1500.00),
(2,1,'KL-L-001','Anoop Menon','Cheque','RCP-2024-003','2024-02-20',5000.00),
(3,3,'KA-AS-001','Lakshmi Nair','UPI','RCP-2024-004','2024-06-25',2500.00),
(6,1,'MH-L-001','Amit Shah','Card','RCP-2024-005','2024-04-12',5000.00);
GO

/* -------------------- STORED PROCEDURES -------------------- */

IF OBJECT_ID('dbo.sp_AuthenticateUser','P') IS NOT NULL DROP PROCEDURE dbo.sp_AuthenticateUser;
GO
CREATE PROCEDURE dbo.sp_AuthenticateUser
    @Username NVARCHAR(50),
    @Password NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT UserId, Username, Role
    FROM   dbo.Users
    WHERE  Username = @Username
      AND  Password = @Password
      AND  IsActive = 1;
END
GO

IF OBJECT_ID('dbo.sp_GetStates','P') IS NOT NULL DROP PROCEDURE dbo.sp_GetStates;
GO
CREATE PROCEDURE dbo.sp_GetStates
AS
BEGIN
    SET NOCOUNT ON;
    SELECT StateId, StateName FROM dbo.States ORDER BY StateName;
END
GO

IF OBJECT_ID('dbo.sp_GetMemberTypes','P') IS NOT NULL DROP PROCEDURE dbo.sp_GetMemberTypes;
GO
CREATE PROCEDURE dbo.sp_GetMemberTypes
AS
BEGIN
    SET NOCOUNT ON;
    SELECT MemberTypeId, MemberTypeName FROM dbo.MemberTypes ORDER BY MemberTypeName;
END
GO

IF OBJECT_ID('dbo.sp_GetMembers','P') IS NOT NULL DROP PROCEDURE dbo.sp_GetMembers;
GO
CREATE PROCEDURE dbo.sp_GetMembers
    @StateId      INT = NULL,
    @MemberTypeId INT = NULL,
    @Search       NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        m.MemberId, m.StateId, m.MemberTypeId,
        s.StateName, mt.MemberTypeName,
        m.MemberNumber, m.ApplicationNo, m.MemberName,
        m.AddressLine1, m.AddressLine2, m.AddressLine3,
        m.Pincode, m.MobileNo, m.AadharNumber,
        m.DOB, m.Gender, m.Profession,
        m.RegisteredThrough, m.RegisteredOn
    FROM dbo.Members m
    INNER JOIN dbo.States       s  ON s.StateId      = m.StateId
    INNER JOIN dbo.MemberTypes  mt ON mt.MemberTypeId = m.MemberTypeId
    WHERE (@StateId      IS NULL OR m.StateId      = @StateId)
      AND (@MemberTypeId IS NULL OR m.MemberTypeId = @MemberTypeId)
      AND (@Search       IS NULL OR
           m.MemberName   LIKE '%' + @Search + '%' OR
           m.MemberNumber LIKE '%' + @Search + '%' OR
           m.ApplicationNo LIKE '%' + @Search + '%' OR
           m.MobileNo     LIKE '%' + @Search + '%' OR
           m.AadharNumber LIKE '%' + @Search + '%')
    ORDER BY m.MemberName;
END
GO

IF OBJECT_ID('dbo.sp_SaveMember','P') IS NOT NULL DROP PROCEDURE dbo.sp_SaveMember;
GO
CREATE PROCEDURE dbo.sp_SaveMember
    @MemberId          INT,
    @StateId           INT,
    @MemberTypeId      INT,
    @MemberNumber      NVARCHAR(50),
    @ApplicationNo     NVARCHAR(50),
    @MemberName        NVARCHAR(200),
    @AddressLine1      NVARCHAR(200),
    @AddressLine2      NVARCHAR(200),
    @AddressLine3      NVARCHAR(200),
    @Pincode           NVARCHAR(10),
    @MobileNo          NVARCHAR(15),
    @AadharNumber      NVARCHAR(20),
    @DOB               DATE,
    @Gender            NVARCHAR(10),
    @Profession        NVARCHAR(100),
    @RegisteredThrough NVARCHAR(50),
    @RegisteredOn      DATE
AS
BEGIN
    SET NOCOUNT ON;

    IF (@MemberId IS NULL OR @MemberId = 0)
    BEGIN
        INSERT INTO dbo.Members
            (StateId, MemberTypeId, MemberNumber, ApplicationNo, MemberName,
             AddressLine1, AddressLine2, AddressLine3, Pincode, MobileNo,
             AadharNumber, DOB, Gender, Profession, RegisteredThrough, RegisteredOn)
        VALUES
            (@StateId, @MemberTypeId, @MemberNumber, @ApplicationNo, @MemberName,
             @AddressLine1, @AddressLine2, @AddressLine3, @Pincode, @MobileNo,
             @AadharNumber, @DOB, @Gender, @Profession, @RegisteredThrough, @RegisteredOn);
    END
    ELSE
    BEGIN
        UPDATE dbo.Members
        SET  StateId           = @StateId,
             MemberTypeId      = @MemberTypeId,
             MemberNumber      = @MemberNumber,
             ApplicationNo     = @ApplicationNo,
             MemberName        = @MemberName,
             AddressLine1      = @AddressLine1,
             AddressLine2      = @AddressLine2,
             AddressLine3      = @AddressLine3,
             Pincode           = @Pincode,
             MobileNo          = @MobileNo,
             AadharNumber      = @AadharNumber,
             DOB               = @DOB,
             Gender            = @Gender,
             Profession        = @Profession,
             RegisteredThrough = @RegisteredThrough,
             RegisteredOn      = @RegisteredOn
        WHERE MemberId = @MemberId;
    END
END
GO

IF OBJECT_ID('dbo.sp_GetRenewals','P') IS NOT NULL DROP PROCEDURE dbo.sp_GetRenewals;
GO
CREATE PROCEDURE dbo.sp_GetRenewals
    @StateId      INT = NULL,
    @MemberTypeId INT = NULL,
    @Search       NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        r.RenewalId, r.StateId, r.MemberTypeId,
        s.StateName, mt.MemberTypeName,
        r.MemberNumber, r.MemberName,
        r.ReceiptType, r.ReceiptNo, r.ReceiptDate, r.Amount
    FROM dbo.Renewals r
    INNER JOIN dbo.States       s  ON s.StateId      = r.StateId
    INNER JOIN dbo.MemberTypes  mt ON mt.MemberTypeId = r.MemberTypeId
    WHERE (@StateId      IS NULL OR r.StateId      = @StateId)
      AND (@MemberTypeId IS NULL OR r.MemberTypeId = @MemberTypeId)
      AND (@Search       IS NULL OR
           r.MemberName   LIKE '%' + @Search + '%' OR
           r.MemberNumber LIKE '%' + @Search + '%' OR
           r.ReceiptNo    LIKE '%' + @Search + '%')
    ORDER BY r.ReceiptDate DESC;
END
GO

IF OBJECT_ID('dbo.sp_SaveRenewal','P') IS NOT NULL DROP PROCEDURE dbo.sp_SaveRenewal;
GO
CREATE PROCEDURE dbo.sp_SaveRenewal
    @RenewalId    INT,
    @StateId      INT,
    @MemberTypeId INT,
    @MemberNumber NVARCHAR(50),
    @MemberName   NVARCHAR(200),
    @ReceiptType  NVARCHAR(50),
    @ReceiptNo    NVARCHAR(50),
    @ReceiptDate  DATE,
    @Amount       DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    IF (@RenewalId IS NULL OR @RenewalId = 0)
    BEGIN
        INSERT INTO dbo.Renewals
            (StateId, MemberTypeId, MemberNumber, MemberName,
             ReceiptType, ReceiptNo, ReceiptDate, Amount)
        VALUES
            (@StateId, @MemberTypeId, @MemberNumber, @MemberName,
             @ReceiptType, @ReceiptNo, @ReceiptDate, @Amount);
    END
    ELSE
    BEGIN
        UPDATE dbo.Renewals
        SET  StateId      = @StateId,
             MemberTypeId = @MemberTypeId,
             MemberNumber = @MemberNumber,
             MemberName   = @MemberName,
             ReceiptType  = @ReceiptType,
             ReceiptNo    = @ReceiptNo,
             ReceiptDate  = @ReceiptDate,
             Amount       = @Amount
        WHERE RenewalId = @RenewalId;
    END
END
GO

IF OBJECT_ID('dbo.sp_Report_MemberList','P') IS NOT NULL DROP PROCEDURE dbo.sp_Report_MemberList;
GO
CREATE PROCEDURE dbo.sp_Report_MemberList
    @FromDate DATE,
    @ToDate   DATE
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        s.StateName              AS [State Name],
        mt.MemberTypeName        AS [Member Type],
        m.MemberNumber           AS [Member Number],
        m.ApplicationNo          AS [Application No],
        m.MemberName             AS [Member Name],
        m.MobileNo               AS [Mobile No],
        m.AadharNumber           AS [Aadhar Number],
        m.Gender                 AS [Gender],
        m.Profession             AS [Profession],
        m.RegisteredThrough      AS [Registered Through],
        m.RegisteredOn           AS [Registered On]
    FROM dbo.Members m
    INNER JOIN dbo.States      s  ON s.StateId      = m.StateId
    INNER JOIN dbo.MemberTypes mt ON mt.MemberTypeId = m.MemberTypeId
    WHERE (m.RegisteredOn IS NULL OR m.RegisteredOn BETWEEN @FromDate AND @ToDate)
    ORDER BY m.RegisteredOn DESC;
END
GO

IF OBJECT_ID('dbo.sp_Report_RenewalList','P') IS NOT NULL DROP PROCEDURE dbo.sp_Report_RenewalList;
GO
CREATE PROCEDURE dbo.sp_Report_RenewalList
    @FromDate DATE,
    @ToDate   DATE
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        s.StateName         AS [State Name],
        mt.MemberTypeName   AS [Member Type],
        r.MemberNumber      AS [Member No],
        r.MemberName        AS [Member Name],
        r.ReceiptType       AS [Receipt Type],
        r.ReceiptNo         AS [Receipt No],
        r.ReceiptDate       AS [Receipt Date],
        r.Amount            AS [Amount]
    FROM dbo.Renewals r
    INNER JOIN dbo.States      s  ON s.StateId      = r.StateId
    INNER JOIN dbo.MemberTypes mt ON mt.MemberTypeId = r.MemberTypeId
    WHERE r.ReceiptDate BETWEEN @FromDate AND @ToDate
    ORDER BY r.ReceiptDate DESC;
END
GO

PRINT 'MembershipDB setup complete.';
PRINT 'Login credentials: admin/admin123  or  user/user123';
GO
