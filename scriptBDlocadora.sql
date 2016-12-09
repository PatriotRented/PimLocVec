create database  BDlocadora;

use BDlocadora;



CREATE TABLE Endereco (

	codEnd INT NOT NULL IDENTITY (1,1),
	rua VARCHAR(50) NOT NULL,
	bairro VARCHAR(50) NOT NULL,
	num VARCHAR(50) NOT NULL,
	complemento VARCHAR(20) DEFAULT 'SEM COMPLEMENTO',
	uf varchar (2) NOT NULL,
	cep VARCHAR(18) NOT NULL,
	cidade VARCHAR(30) NOT NULL
	
constraint pk_end primary key (codEnd)

);

CREATE TABLE Cliente (

	codCli INT NOT NULL  IDENTITY (1,1),
	cnpj_cpf VARCHAR(14) NOT NULL UNIQUE,
	rg varchar(10) null,
	nomeCli varchar(50) NOT NULL,
	emailCli VARCHAR(50) DEFAULT 'SEM E-MAIL',
	dt_nasc datetime NOT NULL,
	cnh VARCHAR(20) NOT NULL UNIQUE,
	tel VARCHAR(20) NOT NULL, 
	codEnd INT NOT NULL,

CONSTRAINT fk_cli_end FOREIGN KEY (codEnd) REFERENCES Endereco(codEnd),
CONSTRAINT pk_cli PRIMARY KEY (codCli));

CREATE TABLE Funcionario (

	codFun INT NOT NULL IDENTITY (1,1),
	cargo VARCHAR(20) NOT NULL,
	dt_admissao datetime NOT NULL,
	cpf VARCHAR(11) NOT NULL UNIQUE,
	nomeFun VARCHAR(50) NOT NULL,
	emailFun VARCHAR(50) DEFAULT 'SEM E-MAIL',
	dt_nasc datetime NOT NULL,
	tel varchar(20) NOT NULL,
	codEnd INT NOT NULL, 
	
constraint pk_fun primary key (codFun)	,
constraint fk_fun_end FOREIGN KEY (codEnd) REFERENCES Endereco(codEnd)

);

CREATE TABLE Categoria (

	codCat INT NOT NULL IDENTITY (1,1),
	nomeCat VARCHAR(20) NOT NULL,
	precoCat MONEY NOT NULL

constraint pk_cat primary key (codCat)
)

insert into Categoria (nomeCat, precoCat) values ('Econômico', 150.00);

CREATE TABLE Acessorio (

	codAce INT NOT NULL IDENTITY (0,1),
	nomeAce VARCHAR(20) NOT NULL,
	precoAce MONEY NOT NULL

constraint pk_ace primary key (codAce)
);

insert into Acessorio(nomeAce,precoAce) values ('Sem Acessorio',00.00);

CREATE TABLE Veiculo (

	codVec INT NOT NULL IDENTITY (1,1),
	codCat INT NOT NULL ,
	modelo VARCHAR(30) NOT NULL,
	marca VARCHAR(20) NOT NULL,
	cor VARCHAR(15) NOT NULL,
	anoVec varchar(4) not null,
	codAce1 int null,
	codAce2 int null,
	codAce3 int null,
	placa VARCHAR(9) NOT NULL,
	statusVec CHAR NOT NULL
constraint pk_vec primary key (codVec),
constraint fk_vecXace_ace1 foreign key (codAce1) references Acessorio(codAce),
constraint fk_vecXace_ace2 foreign key (codAce2) references Acessorio(codAce),
constraint fk_vecXace_ace3 foreign key (codAce3)  references Acessorio(codAce),
constraint fk_vec_cat FOREIGN KEY (codCat) REFERENCES Categoria(codCat)
);

--Tabelas de seguraca
create table LoginTbl(
	cod_log int identity(1,1),
	usu varchar(25),
	password varchar(100),
	constraint pk_login primary key(usu)
);

create table LoginTblSite(
	cod_log int identity(1,1)
	usu varchar(25),
	password varchar(100),
	tipoUsu int,
	codCli int not null,
	
	constraint pk_login_site primary key(usu),
	constraint fk_login_site foreign key(codCli) references Cliente(codCli)
);
--fim das tabelas 

CREATE TABLE Locacao (

codLoc INT NOT NULL PRIMARY KEY IDENTITY (1,1),

codCli INT NOT NULL,
FOREIGN KEY (codCli) REFERENCES Cliente(codCli),
codFun INT NOT NULL,
FOREIGN KEY (codFun) REFERENCES Funcionario(codFun),
codVec INT NOT NULL ,
FOREIGN KEY (codVec) REFERENCES Veiculo(codVec),
tipoPlan INT NOT NULL,


total MONEY NOT NULL,
desco FLOAT DEFAULT '00',
dt_ret DATETIME NOT NULL,
dt_dev DATETIME NOT NULL

)

CREATE TABLE Reserva (

codRes INT NOT NULL PRIMARY KEY IDENTITY (1,1),

codCli INT NOT NULL,
FOREIGN KEY (codCli) REFERENCES Cliente(codCli),
codFun INT NOT NULL,
FOREIGN KEY (codFun) REFERENCES Funcionario(codFun),
codVec INT NOT NULL ,
FOREIGN KEY (codVec) REFERENCES Veiculo(codVec),
tipoPlan INT NOT NULL,


total MONEY NOT NULL,
desco FLOAT DEFAULT '00',
dt_ret DATETIME NOT NULL,
dt_dev DATETIME NOT NULL

)

CREATE TABLE Vistoria (

codVis int identity(1,1),
codLoc int not null,
statusVis int NOT NULL,

constraint pk_vist primary key (codVis),
constraint fk_vist_loc foreign key (codLoc) references Locacao(codLoc)
);

CREATE TABLE Manutencao (

codManu INT NOT NULL PRIMARY KEY IDENTITY (1,1),
codVec INT NOT NULL 
FOREIGN KEY (codVec) REFERENCES Veiculo(codVec),
dt_entrada DATE NOT NULL,
dt_saida DATE NOT NULL

);

CREATE TABLE MetodoPagamento (

codCli INT NOT NULL,
FOREIGN KEY (codCli) REFERENCES Cliente(codCli),
 
codMetPag INT NOT NULL PRIMARY KEY IDENTITY (1,1),
bandeira VARCHAR(20) NOT NULL UNIQUE,
numero VARCHAR(15) NOT NULL UNIQUE

);

--Views
create view selAllVec as 
	select 
		vec.codVec as 'codVec',vec.placa as 'placa', 
		vec.modelo as 'modelo',  vec.marca as 'marca', 
		vec.anoVec as 'ano',vec.cor as 'cor',
		cat.codCat,cat.nomeCat as 'categoria',cat.precoCat as 'precoCat', 
		vec.codAce1,ace1.nomeAce as 'nomeAce1',ace1.precoAce as 'precoAce1',
		vec.codAce2,ace2.nomeAce as 'nomeAce2',ace2.precoAce as'precoAce2',
		vec.codAce3,ace3.nomeAce as 'nomeAce3', ace3.precoAce as 'precoAce3',
		vec.statusVec as 'status', 
		(cat.precoCat + ace1.precoAce + 
						ace2.precoAce + 
						ace3.precoAce ) as 'precoBase'
	from Veiculo vec 
	join 
		Categoria cat 
		on (vec.codCat = cat.codCat)  
	left join 
		Acessorio ace1 
		on (ace1.codAce = vec.codAce1)
	left join 
		Acessorio ace2
		on (ace2.codAce = vec.codAce2)
	left join
		Acessorio ace3
		on (ace3.codAce = vec.codAce3);

create view selectVecCat as 
	select vec.codVec as 'Codigo',vec.placa as 'Placa', 
		vec.modelo as 'Modelo',  vec.marca as 'Marca', vec.anoVec as 'Ano'
		,vec.cor as 'Cor',cat.nomeCat as 'Categoria',
		cat.precoCat as 'Preco Base', vec.statusVec as 'Status'
	 from Veiculo vec 
	 join Categoria cat 
		on (vec.codCat = cat.codCat) ; 
		
create view selAllLoc as

select
	loc.codLoc as 'codLoc',loc.codCli as 'codCli',cli.cnpj_cpf as 'cnpj_cpf' ,
	cli.nomeCli as 'nomeCli', loc.codVec as 'codVec', vec.placa as 'placa',
	vec.modelo as 'modelo',vec.marca 'marca',vec.categoria as 'categoria',
	loc.codFun as 'codFun',fun.nomeFun as 'nomeFun',loc.tipoPlan as 'tipoPlan',
	loc.desco as 'desco',loc.total as 'total',vec.status as 'status'
from 
	Locacao loc
inner join 
	selAllVec vec on (vec.codVec = loc.codVec)
inner join
	Cliente cli on (cli.codCli = loc.codCli)
inner join 
	Funcionario fun on(fun.codFun = loc.codFun);

Create view selForDev as
select
	loc.codLoc as 'codLoc',cli.cnh as 'cnh',
	vec.placa as 'placa', vec.marca 'marca',
	vec.anoVec as 'ano', loc.dt_ret as 'dt_ret',loc.dt_dev as 'dt_dev',
	cli.nomeCli as 'nomeCli'
from 
	Locacao loc
inner join 
	Veiculo vec on (vec.codVec = loc.codVec)
inner join
	Cliente cli on (cli.codCli = loc.codCli)
	
--fim das views

--PROCEDURES

CREATE PROCEDURE sp_cad_cli
	@cnpj_cpf varchar (14),
	@rg varchar (10),
	@nomeCli varchar (50),
	@emailCli varchar (50),
	@dt_nasc_string varchar(13),
	@cnh varchar(20),
	@tel varchar (20),
	@codEnd int
AS

INSERT INTO 
	Cliente (cnpj_cpf,rg,nomeCli, emailCli, dt_nasc, cnh, tel, codEnd)
Values
	(@cnpj_cpf,@rg,@nomeCli, @emailCli,convert(datetime,@dt_nasc_string),@cnh,@tel,@codEnd);

Create view selAllRes as
select
	res.codRes as 'codLoc',res.codCli as 'codCli',cli.cnpj_cpf as 'cnpj_cpf' ,
	cli.nomeCli as 'nomeCli', res.codVec as 'codVec', vec.placa as 'placa',
	vec.modelo as 'modelo',vec.marca 'marca',vec.categoria as 'categoria',
	res.codFun as 'codFun',fun.nomeFun as 'nomeFun',res.tipoPlan as 'tipoPlan',
	res.desco as 'desco',res.total as 'total',vec.status as 'status', 
	res.dt_ret as 'ret', res.dt_dev as 'dev'
from 
	Reserva res
inner join 
	selAllVec vec on (vec.codVec = res.codVec)
inner join
	Cliente cli on (cli.codCli = res.codCli)
inner join 
	Funcionario fun on(fun.codFun = res.codFun);

Create view selAllRes as
select
	res.codRes as 'codLoc',res.codCli as 'codCli',cli.cnpj_cpf as 'cnpj_cpf' ,
	cli.nomeCli as 'nomeCli', res.codVec as 'codVec', vec.placa as 'placa',
	vec.modelo as 'modelo',vec.marca 'marca',vec.categoria as 'categoria',
	res.codFun as 'codFun',fun.nomeFun as 'nomeFun',res.tipoPlan as 'tipoPlan',
	res.desco as 'desco',res.total as 'total',vec.status as 'status', 
	res.dt_ret as 'ret', res.dt_dev as 'dev'
from 
	Reserva res
inner join 
	selAllVec vec on (vec.codVec = res.codVec)
inner join
	Cliente cli on (cli.codCli = res.codCli)
inner join 
	Funcionario fun on(fun.codFun = res.codFun);	
-- FIM

USE [BDlocadora]
GO

INSERT INTO [dbo].[LoginTblSite]
           ([usu]
           ,[password]
           ,[codCli])
     VALUES
           ('Batman',
           '123456',
           1)
GO



--drops das tabelas
drop table Endereco; 
drop table Telefone;
drop table Categoria;
drop table Acessorio;
drop table Cliente;
drop table Funcionario;
drop table Veiculo;
drop table vecXace;

--drops das views
drop view selectVecCat;

-- drops com go
drop table Endereco; 
go
drop table Telefone;
go
drop table Categoria;
go
drop table Acessorio;
go
drop table Cliente;
go
drop table Funcionario;
go
drop table Veiculo;
go
drop table vecXace;

--Deletes com go 
delete from Endereco; 
go
delete from Telefone;
go
delete from Categoria;
go
delete from Acessorio;
go
delete from Cliente;
go
delete from Funcionario;
go
delete from Veiculo;
go
delete from vecXace;


