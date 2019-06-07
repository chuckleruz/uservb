use login

CREATE TABLE [dbo].[usuarios]
(
	[id] INT  NOT NULL PRIMARY KEY IDENTITY(1,1),
	[nombre] VARCHAR(50) NULL,
	[usuario] VARCHAR(50) NULL,
	[contrasena] VARCHAR(50) NULL,
	[email] VARCHAR(50) NULL,
	[tipo_usuario] VARCHAR(50) NULL
)


SELECT * FROM usuarios

INSERT INTO usuarios VALUES('Oscar Flores','Oscarin','123','osca.flores@gmail.com','Admin'),
							('Juan Vazquez','Juanelo','321','juan.vazquez@gmail.com','Usuario'),
							('Miriam Ponce','Miriam','456','miriam.ponce@gmail.com','Usuario')