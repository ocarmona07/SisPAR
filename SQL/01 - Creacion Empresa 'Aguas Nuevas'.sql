-- Creación Empresa
USE SisPAR;

INSERT INTO dbo.EPR_EMPRESA
        ( EPR_RUT ,
          EPR_RUT_DV ,
          EPR_RAZONSOCIAL ,
          EPR_FONO ,
          EPR_DIRECCION ,
          EPR_SUCURSAL
        )
VALUES  ( 76188962 , -- EPR_RUT - int
          '1' , -- EPR_RUT_DV - varchar(1)
          'Aguas Nuevas' , -- EPR_RAZONSOCIAL - varchar(50)
          27334600 , -- EPR_FONO - int
          'Isidora Goyenechea 3600, Las Condes, Santiago' , -- EPR_DIRECCION - varchar(50)
          'Las Condes'  -- EPR_SUCURSAL - varchar(50)
        )