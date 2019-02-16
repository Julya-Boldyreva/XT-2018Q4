CREATE PROC deleteAward @id int
AS
BEGIN
	DELETE FROM award
	WHERE award.id_award = @id
END