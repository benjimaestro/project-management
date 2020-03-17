CREATE PROCEDURE sproc_tblStaff_Insert
--Create parameters for the stored procedure
	@FirstName varchar (7),
	@Surname varchar (11),
	@HouseNo varchar (20),
	@Street varchar (20),
	@PostCode nchar (6),
	@TelephoneNo int ,
	@DOB date , 
	@Manager bit ,
	@Department nchar (10)

	AS
	--Insert new record
	INSERT INTO tblStaff (FirstName, Surname, HouseNo, Street, PostCode, TelephoneNo, DOB, Manager, Departmet)
	values (@FirstName, @Surname, @HouseNo, @Street, @PostCode, @TelephoneNo, @DOB, @Manager, @Department)

	--Return the primary key value of the new record
	return @@Identity