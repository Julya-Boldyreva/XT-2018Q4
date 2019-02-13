CREATE PROC updateAward @title nvarchar(200), @id int
 AS
 BEGIN
	UPDATE City
	SET title = @title
	WHERE id_award =  @id
 END