create or replace function desconto(dsct numeric(18,2))
returns table (customer_id integer,
                rental_date text,
                qtde bigint,
                valor numeric(18,2),
                desconto numeric(18,2),
                taxa numeric(18,2))
language 'sql'
as $$
    select *, case when qtde >= 5 then (valor - (valor*dsct)) else 0 end as desconto, case when qtde >= 5 then (valor * dsct) else 0 end as taxa
    from (
        select r.customer_id, left(cast(rental_date as text),10) rental_date, count(*) qtde, sum(p.amount) valor
        from rental as r
        join payment as p on r.rental_id = p.rental_id and r.customer_id = p.customer_id
        group by r.customer_id, left(cast(rental_date as text),10)
    ) desconto;
end $$;