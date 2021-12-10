if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName, LastName)
	values ('Cuca', 'Beludo'),
	('Valentin','Terra'),
	('Paula','Tejando'),
	('Helma','Marei');
end
GO
