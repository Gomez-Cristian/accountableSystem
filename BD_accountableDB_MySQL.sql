-- ════════════════════════════════════════════════════════════════
--  accountableDB — Script MySQL completo
--  Sistema de Control de Pagos Escolares
--  Politécnico FARDM · 5.º Informática B · 2025-2026
--
--  INSTRUCCIONES:
--    1. Abre MySQL Workbench, HeidiSQL o phpMyAdmin.
--    2. Ejecuta TODO este archivo de una sola vez (Ctrl+Shift+Enter).
--    3. La BD queda lista con tablas, relaciones y datos de prueba.
-- ════════════════════════════════════════════════════════════════

CREATE DATABASE IF NOT EXISTS accountableDB
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_spanish_ci;

USE accountableDB;

-- ── Tabla 1: Roles ──────────────────────────────────────────────
CREATE TABLE IF NOT EXISTS Roles (
    IdRol      INT         NOT NULL AUTO_INCREMENT,
    NombreRol  VARCHAR(30) NOT NULL,
    PRIMARY KEY (IdRol)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ── Tabla 2: Usuarios ───────────────────────────────────────────
CREATE TABLE IF NOT EXISTS Usuarios (
    IdUsuario       INT          NOT NULL AUTO_INCREMENT,
    NombreCompleto  VARCHAR(80)  NOT NULL,
    Username        VARCHAR(30)  NOT NULL UNIQUE,
    Password        VARCHAR(100) NOT NULL,
    IdRol           INT          NOT NULL,
    Activo          TINYINT(1)   NOT NULL DEFAULT 1,
    PRIMARY KEY (IdUsuario),
    CONSTRAINT FK_Usuarios_Roles FOREIGN KEY (IdRol) REFERENCES Roles(IdRol)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ── Tabla 3: Estudiantes ─────────────────────────────────────────
CREATE TABLE IF NOT EXISTS Estudiantes (
    IdEstudiante  INT         NOT NULL AUTO_INCREMENT,
    Nombre        VARCHAR(50) NOT NULL,
    Apellido      VARCHAR(50) NOT NULL,
    Curso         VARCHAR(30) NOT NULL,
    Seccion       VARCHAR(5)  NOT NULL,
    FechaIngreso  DATE        NOT NULL,
    Activo        TINYINT(1)  NOT NULL DEFAULT 1,
    PRIMARY KEY (IdEstudiante)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ── Tabla 4: Contactos ───────────────────────────────────────────
CREATE TABLE IF NOT EXISTS Contactos (
    IdContacto   INT         NOT NULL AUTO_INCREMENT,
    IdEstudiante INT         NOT NULL,
    NombreTutor  VARCHAR(80) NOT NULL,
    Parentesco   VARCHAR(30) NOT NULL,
    Telefono     VARCHAR(20) NOT NULL,
    Correo       VARCHAR(80) NULL,
    PRIMARY KEY (IdContacto),
    CONSTRAINT FK_Contactos_Estudiantes
        FOREIGN KEY (IdEstudiante) REFERENCES Estudiantes(IdEstudiante)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ── Tabla 5: Pagos ───────────────────────────────────────────────
CREATE TABLE IF NOT EXISTS Pagos (
    IdPago       INT            NOT NULL AUTO_INCREMENT,
    IdEstudiante INT            NOT NULL,
    Fecha        DATE           NOT NULL,
    Mes          VARCHAR(20)    NOT NULL,
    Monto        DECIMAL(10,2)  NOT NULL,
    Concepto     VARCHAR(100)   NOT NULL,
    Estado       VARCHAR(20)    NOT NULL DEFAULT 'Pagado',
    PRIMARY KEY (IdPago),
    CONSTRAINT FK_Pagos_Estudiantes
        FOREIGN KEY (IdEstudiante) REFERENCES Estudiantes(IdEstudiante),
    CONSTRAINT CHK_Monto CHECK (Monto > 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ── Tabla 6: Facturas ────────────────────────────────────────────
CREATE TABLE IF NOT EXISTS Facturas (
    IdFactura    INT           NOT NULL AUTO_INCREMENT,
    IdPago       INT           NOT NULL,
    IdEstudiante INT           NOT NULL,
    NumFactura   VARCHAR(20)   NOT NULL UNIQUE,
    FechaEmision DATE          NOT NULL,
    Total        DECIMAL(10,2) NOT NULL,
    Estado       VARCHAR(20)   NOT NULL DEFAULT 'Emitida',
    PRIMARY KEY (IdFactura),
    CONSTRAINT FK_Facturas_Pagos
        FOREIGN KEY (IdPago) REFERENCES Pagos(IdPago),
    CONSTRAINT FK_Facturas_Estudiantes
        FOREIGN KEY (IdEstudiante) REFERENCES Estudiantes(IdEstudiante)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


-- ════════════════════════════════════════════════════════════════
--  DATOS DE PRUEBA
-- ════════════════════════════════════════════════════════════════

INSERT INTO Roles (NombreRol) VALUES ('Administrador'), ('Registro');

-- Contraseña en texto plano para este proyecto escolar.
INSERT INTO Usuarios (NombreCompleto, Username, Password, IdRol, Activo) VALUES
    ('Administrador del Sistema', 'admin',   'admin123', 1, 1),
    ('María García',              'mgarcia', 'reg123',   2, 1),
    ('Pedro López',               'plopez',  'reg456',   2, 0);

INSERT INTO Estudiantes (Nombre, Apellido, Curso, Seccion, FechaIngreso, Activo) VALUES
    ('Ana',    'Pérez',     '5to', 'A', '2026-01-10', 1),
    ('Juan',   'García',    '5to', 'B', '2026-01-10', 1),
    ('María',  'Rodríguez', '4to', 'A', '2025-09-01', 1),
    ('Carlos', 'López',     '6to', 'C', '2024-09-01', 1),
    ('Laura',  'Martínez',  '3ro', 'A', '2025-09-01', 1);

INSERT INTO Contactos (IdEstudiante, NombreTutor, Parentesco, Telefono, Correo) VALUES
    (1, 'Rosa Pérez',       'Madre',  '809-555-0101', 'rosa.perez@mail.com'),
    (2, 'Luis García',      'Padre',  '829-555-0202', NULL),
    (3, 'Carmen Díaz',      'Madre',  '849-555-0303', 'carmen.diaz@mail.com'),
    (4, 'Jorge López',      'Padre',  '809-555-0404', NULL),
    (5, 'Sandra Martínez',  'Madre',  '829-555-0505', 'sandra@mail.com');

INSERT INTO Pagos (IdEstudiante, Fecha, Mes, Monto, Concepto, Estado) VALUES
    (1, '2026-01-10', 'Enero',    2500.00, 'Cuota de enero',    'Pagado'),
    (1, '2026-02-08', 'Febrero',  2500.00, 'Cuota de febrero',  'Pagado'),
    (1, '2026-03-05', 'Marzo',    2500.00, 'Cuota de marzo',    'Pagado'),
    (2, '2026-01-12', 'Enero',    2500.00, 'Cuota de enero',    'Pagado'),
    (2, '2026-02-10', 'Febrero',  2500.00, 'Cuota de febrero',  'Pagado'),
    (3, '2026-01-15', 'Enero',    2500.00, 'Cuota de enero',    'Pagado'),
    (4, '2026-01-20', 'Enero',    2500.00, 'Cuota de enero',    'Pagado'),
    (4, '2026-02-18', 'Febrero',  2500.00, 'Cuota de febrero',  'Pagado'),
    (5, '2026-02-20', 'Febrero',  2500.00, 'Cuota de febrero',  'Pagado');

INSERT INTO Facturas (IdPago, IdEstudiante, NumFactura, FechaEmision, Total, Estado) VALUES
    (1, 1, 'FAC-0001', '2026-01-10', 2500.00, 'Emitida'),
    (2, 1, 'FAC-0002', '2026-02-08', 2500.00, 'Emitida'),
    (3, 1, 'FAC-0003', '2026-03-05', 2500.00, 'Emitida'),
    (4, 2, 'FAC-0004', '2026-01-12', 2500.00, 'Emitida'),
    (5, 2, 'FAC-0005', '2026-02-10', 2500.00, 'Emitida'),
    (6, 3, 'FAC-0006', '2026-01-15', 2500.00, 'Emitida'),
    (7, 4, 'FAC-0007', '2026-01-20', 2500.00, 'Emitida'),
    (8, 4, 'FAC-0008', '2026-02-18', 2500.00, 'Emitida'),
    (9, 5, 'FAC-0009', '2026-02-20', 2500.00, 'Emitida');
