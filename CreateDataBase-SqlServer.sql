Create Database dbCursoCsharp;
go
use dbCursoCsharp;
go
create table Montadora (
ID int Identity not null primary key,
Nome varchar(50) not Null,
Logo varchar(100) not Null,);
go