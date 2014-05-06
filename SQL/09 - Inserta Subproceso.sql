--inserta subproceso

USE SisPAR;

 INSERT INTO dbo.SPO_SUBPROCESO
                            ( SPO_PRO_ID ,
                              SPO_NOMBRE ,
                              SPO_USU_ID ,
                              SPO_OBSERVACION
                            )
                    VALUES  ( 1 , -- SPO_PRO_ID - int
                              'Recaudación' , -- SPO_NOMBRE - varchar(50)
                              1 , -- SPO_USU_ID - int
                              'Recaudación N° 1'  -- SPO_OBSERVACION - varchar(max)
                            )
     