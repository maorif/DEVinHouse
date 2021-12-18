document.body.onload = Addh3Element();

function PrimeNumberChecker(number){

    let result = `O número ${number} é primo.`;

    if(number <= 1 || !Number.isInteger(number)){
        result = `O númer deve ser inteiro e maior que 1!`;
        return result;
    }

    for(i=2; i<number; i++){

        if(number > 1 && number%i == 0){
            result = `O número ${number} NÃO é primo. É divisível por ${i}.`;
            return result;
        }
    }

    return result;
}

function Addh3Element(){
    let newh3 = document.createElement("h3");
    
    newh3.id = "result";
    newh3.style = "none";

    document.getElementById("prime-checker").appendChild(newh3);
    
}


function Send(){
    let number = document.getElementById("number");

    let result = PrimeNumberChecker(Number(number.value));
    let resultString = document.createTextNode(result);
    
    document.getElementById("result").innerHTML = "";

    document.getElementById("result").appendChild(resultString);

}