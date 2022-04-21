create view vw_transferencias
as
select numero_conta_origem as conta de origem,
numero_conta_destino as conta de destino,
data_transacao, 
valor 
from transferencias;

--select * from vw_transferencias
-- where data_transacao between '2019-01-01' and '2019-01-31';

create view vw_saldo_negativo
as
    select numero_conta, (deposito - saque) saldo from (
        select numero_conta,
            sum(case when tt.descricao == 'saque' then valor else 0 end) as saque,
            sum(case when tt.descricao == 'deposito' then valor else 0 end) as deposito
        from transacoes as t
        join tipo_transacao as tt
            on t.cod_tptransacao = tt.cod_transacao and cod_transacao in (1,2)
        group by numero_conta
    )

    select numero_conta_origem, 
        'Transaferência' as descricao,
        sum(valor) * -1 as valor
    from transferencias
    group by numero_conta_origem
    union all
    select numero_conta_destino, 
        'Transaferência' as descricao,
        sum(valor) * -1 as valor
    from transferencias
    group by numero_conta_destino
