ALTER TRIGGER dbo.Trigger_AfterUpdate_usr_User
ON usr_User
AFTER UPDATE
AS
BEGIN
    IF UPDATE(FullName) OR UPDATE(Designation) OR UPDATE(ProfilePic)
    BEGIN

		DECLARE 
		@userName NVARCHAR(400), 
		@userEmpId NVARCHAR(100), 
		@Designation NVARCHAR(100), 
		@photoUrl NVARCHAR(100), 
		@userInital NVARCHAR(10)

		SELECT TOP 1 @photoUrl = ISNULL(ProfilePic,''), 		
				@userEmpId = ISNULL(EmployeeID,''), 
				@userName = ISNULL(fullname,''), 
				@Designation = ISNULL(Designation,''),
				@userInital = dbo.Fun_GetInitials(ISNULL(fullname,''))
		FROM	inserted 

		IF EXISTS (SELECT TOP 1 * FROM gen_ChannelHistory WHERE userempid = @userEmpId)
		BEGIN
			DECLARE @APIURL NVARCHAR(MAX);

			SET @APIURL = @UpChatAPI_URL + 'User/UpdateDetail';
        
			Exec sp_OACreate 'MSXML2.XMLHTTP', @Object OUT;

			INSERT INTO StoreAPIURL(APIUrl, ResponseStatus)
		END
    END
END;