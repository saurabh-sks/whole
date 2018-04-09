Use [WholesaleRaja]
GO

ALTER PROCEDURE WSR_Delete_And_Add_Roles_To_User
	@UserId		  uniqueidentifier,
	@RoleIds		  nvarchar(4000)

AS
BEGIN
	DECLARE @Num	  int
	DECLARE @Pos	  int
	DECLARE @NextPos  int
	DECLARE @RoleId	  nvarchar(256)
	DECLARE @userRoles  table(Userid uniqueidentifier NOT NULL, UserRole uniqueidentifier NOT NULL)

	SET @Num = 0
	SET @Pos = 1
	WHILE(@Pos <= LEN(@RoleIds))
	BEGIN
		SELECT @NextPos = CHARINDEX(N',', @RoleIds,  @Pos)
		IF (@NextPos = 0 OR @NextPos IS NULL)
			SELECT @NextPos = LEN(@RoleIds) + 1
		SELECT @RoleId = RTRIM(LTRIM(SUBSTRING(@RoleIds, @Pos, @NextPos - @Pos)))
		SELECT @Pos = @NextPos+1

		INSERT INTO @userRoles VALUES (@UserId,@RoleId)
		SET @Num = @Num + 1
	END

	DELETE FROM aspnet_UsersInRoles WHERE UserId = @UserId
	INSERT INTO aspnet_UsersInRoles (UserId, RoleId)
		SELECT Userid, UserRole FROM @userRoles WHERE Userid = @UserId

END