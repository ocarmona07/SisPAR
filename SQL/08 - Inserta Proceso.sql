--inserta proceso


USE SisPAR;

 INSERT INTO dbo.PRO_PROCESO
              ( PRO_NOMBRE ,
                PRO_TIP_ID ,
                PRO_EPR_ID ,
                PRO_USU_ID ,
                PRO_OBSERVACION
              )
      VALUES  ( 'Facturación' , -- PRO_NOMBRE - varchar(50)
                2 , -- PRO_TIP_ID - int
                1 , -- PRO_EPR_ID - int
                1 , -- PRO_USU_ID - int
                'Facturación Administrativa'  -- PRO_OBSERVACION - varchar(max)
              )