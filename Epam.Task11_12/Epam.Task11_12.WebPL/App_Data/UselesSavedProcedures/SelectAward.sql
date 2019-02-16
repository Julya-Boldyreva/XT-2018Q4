CREATE PROC showAwards
 AS
 BEGIN
	SELECT title AS 'Award Title'
	FROM award
 END