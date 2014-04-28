-- Insertar Estados

USE SisPAR;

INSERT  INTO dbo.EST_ESTADOS
        ( EST_TIPO, EST_OBSERVACION )
VALUES  ( 'Abierto',
          'Requerimiento ingresado por el cliente a la plataforma PAR.' ) ,
        ( 'Asignado',
          'Requerimiento asignado por el ADR al analista que realizar� la atenci�n del requerimiento.' ) ,
        ( 'Derivado',
          'El ADR o Analista deriva la solicitud hacia otro proceso o subproceso, seg�n corresponda.' ) ,
        ( 'Proveedor',
          'El ADR o analista requiere el apoyo de un proveedor para atender el Requerimiento.' ) ,
        ( 'Cierre Preliminar',
          'Concluye la atenci�n del requerimiento, por lo tanto se solicita el V�B� del Cliente.' ) ,
        ( 'Cerrado',
          'Se cierra el requerimiento de atenci�n, esta acci�n la realiza el cliente (V�B�) o por timeout.' )