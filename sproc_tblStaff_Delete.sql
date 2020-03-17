CREATE PROCEDURE [dbo].sproc_tblStaff_Delete

--This stored procedure is situated in the data layer (App_Data folder)
--This is used to delete a single record from tblStaff
--It accepts a single parameter @StafNo and returns no value

--Declare the parameter
@StaffNO int

AS

--Delete the record in tblStaff
delete from tblStaff where StaffNo = @StaffNO;