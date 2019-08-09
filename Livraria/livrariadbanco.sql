create database livraria;
use livraria;
create table cliente(
id int auto_increment primary key,
nome varchar(100) not null,
email varchar(100) not null,
cpf varchar(15) not null,
telefone varchar(15) not null,
senha varchar(200) not null
);

create table produto(
id int auto_increment primary key,
nome varchar(100) not null,
descricao text not null,
preco decimal(10,2) not null,
quantidade int not null,
imagem varchar(200) not null
);

create table venda(
id int auto_increment primary key,
idcliente int not null,
datavenda timestamp default current_timestamp()
);

create table detalhe(
id int auto_increment primary key,
idvenda int not null,
idproduto int not null,
quantidade int not null
);