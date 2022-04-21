create table cliente (ID serial, nome varchar(250) not null
					   ,CPF varchar(14) unique not null, endereco text not null);

create table conta (ID serial, numero_conta varchar(50) unique not null, tipo_conta int not null
					, CPF varchar(14) not null, id_agencia int not null
				   ,constraint conta_agencia foreign key (id_agencia) references public.agencia (id_agencia)
                   ,constraint CPF foreign key (CPF) references public.cliente (CPF)
			);

alter table conta
	add constraint conta_tpConta foreign key (tipo_conta) references tipo_conta (codigo);

create table tipo_conta ( id serial
	, codigo integer unique not null
	, descricao varchar(50));

create table beneficios( id serial
	, cod_beneficio integer unique not null
	, descricao varchar(150)
	, cod_tpConta integer
	, constraint benf_tpConta foreign key (cod_tpConta) references tipo_conta (codigo));

create table agencia ( id serial
	,cod_agencia integer unique not null);

create table tipo_transacoes ( id serial
	, cod_transacao integer unique not null
	, descricao varchar(25) not null);

create table transacoes (id serial
	, cod_tpTransacao integer not null
	, data_transacao timestamp
	, numero_conta varchar(50) not null
	, valor numeric(18,2)
	,constraint conta_transacoes foreign key (numero_conta)	references conta (numero_conta)
	,constraint transacoes_tpTransacoes foreign key (cod_tpTransacao) references tipo_transacoes (cod_transacao) );

create table transferecias (id serial
	, numero_conta_origem varchar(50) not null
	, numero_conta_destino varchar(50) not null
	, cod_tpTransacao integer
	, data_transacao timestamp
	,valor numeric(18,2)
	,constraint conta_transf foreign key (numero_conta_origem)	references conta (numero_conta)
	,constraint transf_tpTransacoes foreign key (cod_tpTransacao) references tipo_transacoes (cod_transacao));