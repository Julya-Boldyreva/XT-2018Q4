CREATE PROC showUsers
 AS
 BEGIN
	SELECT name AS 'name', bi
	FROM dbo.users
 END