import json

print("Digite o nome do arquivo de dados")
input_data = input()

f = open(input_data, 'r')
data = json.load(f)

dataToPsql = open('data_to_psql.txt', 'w')

for clients in data:
    client_info = {}
    for info in clients:
        if info == "nome":
            client_info["nome"] = clients[info]
        elif info == "cpf":
            client_info["cpf"] = clients[info]
        elif info == "endereco":
            client_info["endereco"] = clients[info]
    
    dataToPsql.write("{c}\n\n".format(c = client_info))

f.close()
dataToPsql.close()

        

