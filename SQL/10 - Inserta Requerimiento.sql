--Inserta Requerimiento

USE SisPAR;

INSERT INTO dbo.REQ_REQUERIMIENTO
        ( REQ_FECHA_ING ,
          REQ_FECHA_ASIGN ,
          REQ_FECHA_DERIV ,
          REQ_FECHA_PROV ,
          REQ_FECHA_CIERRE_PRE ,
          REQ_FECHA_CIERRE_DEF ,
          REQ_TIPO_CIERRE ,
          REQ_GLOSA_USU ,
          REQ_DESC_TEC ,
          REQ_PLAZO_ATENC ,
          REQ_PRO_ID ,
          REQ_SPO_ID ,
          REQ_URG_ID ,
          REQ_EST_ID ,
          REQ_RES_ID ,
          REQ_EPR_ID ,
          REQ_USU_ID ,
          REQ_ARC_ADJUNTO
        )
VALUES  ( '2014-05-02' , -- REQ_FECHA_ING - date
          '2014-05-02' , -- REQ_FECHA_ASIGN - date
          '2014-05-03' , -- REQ_FECHA_DERIV - date
          '2014-05-03' , -- REQ_FECHA_PROV - date
          '2014-05-08' , -- REQ_FECHA_CIERRE_PRE - date
          '2014-05-10' , -- REQ_FECHA_CIERRE_DEF - date
          'Cierre Preliminar' , -- REQ_TIPO_CIERRE - varchar(50)
          'Solicitud ingresada por Rosby Hidalgo' , -- REQ_GLOSA_USU - varchar(max)
          'Problemas con la carga de fotos al sistema.' , -- REQ_DESC_TEC - varchar(max)
          30 , -- REQ_PLAZO_ATENC - int
          1 , -- REQ_PRO_ID - int
          1 , -- REQ_SPO_ID - int
          1 , -- REQ_URG_ID - int
          1 , -- REQ_EST_ID - int
          1 , -- REQ_RES_ID - int
          1 , -- REQ_EPR_ID - int
          1 , -- REQ_USU_ID - int
          'c:\\SisPAR\\Notificacion\\Adjuntos\\Test.txt'  -- REQ_ARC_ADJUNTO - image
        )