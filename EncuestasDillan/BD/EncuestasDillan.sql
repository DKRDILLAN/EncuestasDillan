-- Crear la base de datos
CREATE DATABASE EncuestasDillan;
USE EncuestasDillan;

-- Crear la tabla
CREATE TABLE Encuestas (
    NumeroEncuesta INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    FechaNacimiento DATE CHECK (DATEDIFF(YEAR, FechaNacimiento, GETDATE()) BETWEEN 18 AND 50) NOT NULL,
    CorreoElectronico VARCHAR(50) CHECK (CorreoElectronico LIKE '%@%.%') NOT NULL,
    PartidoPolitico VARCHAR(10) CHECK (PartidoPolitico IN ('PLN', 'PUSC', 'PAC')) NOT NULL
);



-- Procedimiento almacenado para agregar encuestas
CREATE PROCEDURE AgregarEncuesta
    @Nombre VARCHAR(50),
    @FechaNacimiento DATE,
    @CorreoElectronico VARCHAR(50),
    @PartidoPolitico VARCHAR(10)
AS
BEGIN
    INSERT INTO Encuestas (Nombre, FechaNacimiento, CorreoElectronico, PartidoPolitico)
    VALUES (@Nombre, @FechaNacimiento, @CorreoElectronico, @PartidoPolitico);
END;


-- Procedimiento almacenado para el reporte de encuestas
CREATE PROCEDURE ReporteEncuestas
AS
BEGIN
    SELECT * FROM Encuestas;
END;