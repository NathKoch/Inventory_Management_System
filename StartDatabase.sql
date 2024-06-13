--  Connecting to Microsoft SQL Server from cmd
sqlcmd -S DESKTOP-yourname\SQLEXPRESS -E

CREATE DATABASE InventoryManagementSystemDB;
GO

USE InventoryManagementSystemDB;
GO

CREATE TABLE Inventory (
    id int IDENTITY(1,1) NOT NULL,
    type_of varchar(50) NOT NULL,
    count_of int NOT NULL,
    supplier varchar(50) NOT NULL,
    price int NOT NULL,
    PRIMARY KEY (id) 
);
GO


INSERT INTO  Inventory (type_of, count_of, supplier, price) VALUES ('Canon EOS R10', 2, 'Canon', 959)
GO

-- SELECT * FROM Inventory;
-- GO

CREATE TABLE Users (
    id int IDENTITY(1,1) NOT NULL,
    login_user varchar(50) NOT NULL,
    password_user varchar(50) NOT NULL,
    permission bit,
    PRIMARY KEY(id) 
);
GO

INSERT INTO Users (login_user, password_user, permission) VALUES ('admin', '21232F297A57A5A743894A0E4A801FC3', 1)
GO 
-- password = admin

-- SELECT * FROM Users;
-- GO




