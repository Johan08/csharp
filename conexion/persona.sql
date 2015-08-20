create table persona(
perso_id int,
perso_rut char(11),
perso_nombre varchar(100),
perso_fechnac datetime,
primary key(perso_id)
);


SELECT TOP 1000 [perso_id]
      ,[perso_rut]
      ,[perso_nombre]
      ,[perso_fechnac]
  FROM [model].[dbo].[persona]






select max(perso_id) from dbo.persona;