CREATE DATABASE db_GastosPersonales;
GO
USE db_GastosPersonales;
GO

-- Creación de tablas
CREATE TABLE Reportes (
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Fecha_inicial SMALLDATETIME NOT NULL,
    Fecha_final SMALLDATETIME NOT NULL,
    Saldo FLOAT NOT NULL,
    Total_ingresos FLOAT NOT NULL,
    Total_egresos FLOAT NOT NULL
);

CREATE TABLE Tipos_transacciones (
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL
);

CREATE TABLE Categorias (
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255)
);

CREATE TABLE Monedas (
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Relacion FLOAT NOT NULL
);

CREATE TABLE Conversiones (
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Valor_original FLOAT NOT NULL,
    Valor_convertido FLOAT NOT NULL,
    Id_tipo_moneda INT NOT NULL,
    FOREIGN KEY (Id_tipo_moneda) REFERENCES Monedas(Id)
);

CREATE TABLE Transacciones (
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Fecha SMALLDATETIME NOT NULL,
    Id_conversion INT NOT NULL,
    Id_tipo INT NOT NULL,
    Id_categoria INT NOT NULL,
    Id_reporte INT NOT NULL,
    FOREIGN KEY (Id_conversion) REFERENCES Conversiones(Id),
    FOREIGN KEY (Id_tipo) REFERENCES Tipos_transacciones(Id),
    FOREIGN KEY (Id_categoria) REFERENCES Categorias(Id),
    FOREIGN KEY (Id_reporte) REFERENCES Reportes(Id)
);

CREATE TABLE Recordatorios (
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Fecha_inicial SMALLDATETIME NOT NULL,
    Frecuencia_dias INT NOT NULL
);

CREATE TABLE Metas (
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Monto FLOAT NOT NULL,
    Progreso FLOAT NOT NULL,
    Finalizado BIT NOT NULL,
    Id_recordatorio INT NOT NULL,
    FOREIGN KEY (Id_recordatorio) REFERENCES Recordatorios(Id)
);

-- Inserción de datos de ejemplo
INSERT INTO Reportes (Fecha_inicial, Fecha_final, Saldo, Total_ingresos, Total_egresos) 
VALUES (GETDATE(), GETDATE(), 1000, 2000, 1000);

INSERT INTO Tipos_transacciones (Nombre) 
VALUES ('Ingreso'), ('Egreso');

INSERT INTO Categorias (Nombre, Descripcion) 
VALUES ('Alimentación', 'Gastos en comida'), ('Transporte', 'Gastos en transporte');

INSERT INTO Monedas (Nombre, Relacion) 
VALUES ('COP', 1.0), ('USD', 4147.50);

INSERT INTO Conversiones (Valor_original, Valor_convertido, Id_tipo_moneda) 
VALUES (2000000, 2000000, 1);

INSERT INTO Transacciones (Fecha, Id_conversion, Id_tipo, Id_categoria, Id_reporte) 
VALUES (GETDATE(), 1, 1, 1, 1);

INSERT INTO Recordatorios (Nombre, Fecha_inicial, Frecuencia_dias) 
VALUES ('Pago de arrienndo', GETDATE(), 30);

INSERT INTO Metas (Nombre, Monto, Progreso, Finalizado, Id_recordatorio) 
VALUES ('Ahorro viaje', 5000, 1000, 0, 1);

-- Consulta para verificar datos
SELECT * FROM Transacciones;