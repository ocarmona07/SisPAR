-- Insertar Urgencias

USE SisPAR;

INSERT  INTO dbo.URG_URGENCIA
        ( URG_TIPO, URG_OBSERVACION )
VALUES  ( 'Bajo', 'Prioriodad m�nima' ),
        ( 'Medio', 'Prioridad estandar' ) ,
        ( 'Alto', 'M�xima prioridad' )