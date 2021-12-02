//Função que calcula média de números de um array

function Mean(array) {
    return array.reduce((a, b) => (a + b))/array.lenght;
}

const name = "João";

export { name, Mean };