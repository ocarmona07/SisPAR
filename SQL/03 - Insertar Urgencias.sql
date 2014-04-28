-- Insertar Urgencias

USE SisPAR;

INSERT  INTO dbo.URG_URGENCIA
        ( URG_TIPO, URG_OBSERVACION )
VALUES  ( 'Bajo', 'Prioriodad mínima' ),
        ( 'Medio', 'Prioridad estandar' ) ,
        ( 'Alto', 'Máxima prioridad' )