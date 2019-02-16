CREATE PROC updateAward @title nvarchar(200), @id int
 AS
 BEGIN
	UPDATE award
	SET title = @title
	WHERE id_award =  @id
 END