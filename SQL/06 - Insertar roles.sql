 -- Insertar roles
USE SisPAR
 
 
 INSERT INTO dbo.ROL_ROL
                 ( ROL_NOMBRE, ROL_DESCRIPCION )
         VALUES  ( 'Administrador', -- ROL_NOMBRE - varchar(25)
                   'Usuario principal que maneja el sistema'  -- ROL_DESCRIPCION - varchar(max)
                   ),
                   (
                   'Usuario',
                   'usuario del Sistema'
                   )