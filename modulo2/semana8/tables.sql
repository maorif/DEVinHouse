create table clientes (ID serial, nome varchar(250) not null
					   ,CPF varchar(14) unique not null, endereco text not null);

create table agencias (ID serial, id_agencia int unique not null, descricao varchar(50));

create table contas (ID serial, numero_conta varchar(50) unique not null, tipo_conta int not null
					, CPF varchar(14) not null, id_agencia int not null
				   ,constraint conta_agencia foreign key (id_agencia) references public.agencia (id_agencia)
                   ,constraint CPF foreign key (CPF) references public.clientes (CPF)
			);

create table tipo_conta(ID serial, id_tipo_conta int unique not null, descricao varchar(50));

create table beneficios(ID serial, id_beneficios int unique not null, descricao varchar(50));

create table transacoes(ID serial, id_transferencia int unique not null, num_conta varchar(50), valor numeric, id_tipo_transacao int not null,
						constraint id_tipo_transacao foreign key (id_tipo_transacao) references public.tipo_transacao (id_tipo_transacao));

create table tipo_transacao(ID serial, id_tipo_transacao int unique not null, descricao varchar(50));