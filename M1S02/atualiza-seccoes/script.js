
function Participar(){
    document.getElementsByClassName("form")[0].style.display = "block";
}

let inputs = document.getElementsByClassName("data");
let data = {number: 0, meanAge: 0, satisfied: 0};
let dataShown = document.getElementsByClassName("number");

function RefreshData(inputs){
    data.number += 1;

    if(data.meanAge == 0){
        data.meanAge = Number(inputs[2].value);
    }
    else{
        data.meanAge = ((data.meanAge + Number(inputs[2].value))/2 ).toFixed(2);
    }
    
    if (inputs[3].value == 'sim'){
        data.satisfied += 1;
    }
}

function Enviar(){
    RefreshData(inputs);

    dataShown[0].innerHTML = data.number;
    dataShown[1].innerHTML = data.meanAge;
    dataShown[2].innerHTML = data.satisfied;

    for (i=0; i<inputs.length; i++){
        //inputs[i].value = "";
    }
}