CREATE PROC addAwardToList @title nvarchar(200)
 AS
 BEGIN
	INSERT INTO award (title) VALUES (@title)
 END