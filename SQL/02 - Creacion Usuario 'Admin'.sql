-- Creación Admin
USE SisPAR;

INSERT INTO dbo.USU_USUARIO
        ( USU_RUT ,
          USU_RUT_DV ,
          USU_NOMBRE ,
          USU_APELLIDO ,
          USU_FONO ,
          USU_DIRECCION ,
          USU_CARGO ,
          USU_CORREO ,
          USU_EPR_ID ,
          USU_PASSWORD
        )
VALUES  ( 15988820 , -- USU_RUT - int
          '7' , -- USU_RUT_DV - varchar(1)
          'Omar' , -- USU_NOMBRE - varchar(50)
          'Carmona Rivas' , -- USU_APELLIDO - varchar(50)
          82433600 , -- USU_FONO - int
          'Las Heras 1040 Dpto. 13 Torre Nahuelbuta' , -- USU_DIRECCION - varchar(100)
          'Administrador' , -- USU_CARGO - varchar(50)
          'ocarmona07@gmail.com' , -- USU_CORREO - varchar(50)
          1 , -- USU_EPR_ID - int
          '123456'  -- USU_PASSWORD - varchar(15)
        )