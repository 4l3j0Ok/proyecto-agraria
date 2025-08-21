IF NOT EXISTS (
    SELECT *
    FROM sys.databases
    WHERE name = 'GestionAgraria'
) BEGIN CREATE DATABASE GestionAgraria
END;