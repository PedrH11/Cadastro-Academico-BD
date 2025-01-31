create database if not exists academico;

use academico;

create table aluno(
    id int not null auto_increment,
    matricula varchar(15) not null,
    nome varchar(80) not null,
    dt_nascimento datetime not null,
    endereco varchar(80) not null,
    bairro varchar(80) not null,
    cidade varchar(80) not null,
    estado varchar(02) not null,
    senha varchar(20) not null,
    primary key (id)
);

create table curso(
	id_curso int not null auto_increment,
    cod_curso varchar(15) not null,
    nome_curso varchar(50) not null,
    nivel varchar(25) not null,
    duracao int not null,
    area varchar(30) not null,
    periodo varchar (25) not null,
    primary key (id_curso)
);

alter table curso modify nome_curso varchar(50);
