# apaga base para reescrevê-la
drop database if exists dbenersave;

# cria banco de dados dbenersave
create database dbenersave;

# muda para banco de dados criado
use dbenersave;

# cria tabela de usuários
create table tusuarios (
	id int primary key auto_increment,
    nome varchar(30) not null,
    login varchar(20) not null,
    senha varchar(20) not null,
    administrador int not null
);


insert into tusuarios values (null, "Carla Macedo", "carla@email.com", "456", 0);
insert into tusuarios values (null, "Tiago Santos", "tiago@email.com", "123", 1);
insert into tusuarios values (null, "Suzana Souza", "suzana@email.com", "789", 0);
insert into tusuarios values (null, "Maria da Silva", "maria@email.com", "534", 0);
insert into tusuarios values (null, "Antônio Pereira Machado", "antonio@email.com", "789", 0);
insert into tusuarios values (null, "Marília Lima", "marilia@email.com", "895", 0);
insert into tusuarios values (null, "Jonas Santos", "jonas@email.com", "3urhfju", 0);
insert into tusuarios values (null, "Belle Delphine", "belle@email.com", "kfdd9BB", 0);
insert into tusuarios values (null, "Neymar Júnior", "neymar@email.com", "Abtdg78&hsg", 0);


# cria tabela de gastos de água
create table tgastos_agua (
	id int primary key auto_increment,
    metros_cubicos numeric(12, 2) not null,
    periodo date not null,
    usu_id int not null,
    constraint fk_agua_usuario foreign key(usu_id) references tusuarios (id) on delete cascade on update cascade
);


# cria tabela de gastos de energia
create table tgastos_energia(
	id int primary key auto_increment,
    kwh numeric(10, 2),
    valor numeric(10, 2),
   	periodo date,
    usu_id int not null,
    constraint fk_energia_usuario foreign key(usu_id) references tusuarios (id) on delete cascade on update cascade
);


# cria tabela de descarte de lixo
create table tdescarte_lixo(
	id int primary key auto_increment,
    peso numeric(10, 2),
    periodo date,
    reciclavel boolean,
    organico boolean,
    eletronico boolean,
    observacao varchar(2000),
    usu_id int not null,
    constraint fk_lixo_usuario foreign key(usu_id) references tusuarios (id) on delete cascade on update cascade
);

