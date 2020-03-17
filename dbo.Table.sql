CREATE TABLE [dbo].[tblStaff]
(
	[StaffNo] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(7) NOT NULL, 
    [Surname] VARCHAR(11) NOT NULL, 
    [HouseNo] VARCHAR(20) NOT NULL, 
    [Street] VARCHAR(20) NOT NULL, 
    [PostCode] NCHAR(6) NOT NULL, 
    [TelephoneNo] INT NOT NULL, 
    [DOB] DATE NOT NULL, 
    [Manager] INT NULL, 
    [Departmet] NCHAR(10) NULL
)
