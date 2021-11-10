function AddItem(){

    let itens = document.getElementsByClassName("flex-item");
    let newLi = document.createElement("li");
    newLi.className = "flex-item";
    let newNumb = document.createTextNode(`${itens.length+1}`);
    let newInputNumb = document.createElement("input");
    newInputNumb.className = "order";
    newInputNumb.type = "number";
    let newInputColor = document.createElement("input");
    newInputColor.className = "s-color";
    newInputColor.type = "color";
    newInputColor.value = "#ff6347";

    newLi.appendChild(newNumb);
    newLi.appendChild(newInputNumb);
    newLi.appendChild(newInputColor);
    document.getElementsByClassName("flex-container")[0].appendChild(newLi);

    //ChangeSingleBlockRandom();
    ChangeSingleBlockColor();
    ChangeSingleBlockOrder();
}

function DeleteItem(){
    
    let container = document.getElementsByClassName("flex-container")[0];
    container.removeChild(container.lastChild);
}

function InvertOrder(){

    let container = document.getElementsByClassName("flex-container")[0];

    if (container.style.flexFlow == "row wrap"){
        container.style.flexFlow = "row-reverse wrap-reverse";
    }

    else {
        container.style.flexFlow = "row wrap";
    }
}

//change justify-content
function ChangeJustify(){
    let container = document.getElementsByClassName("flex-container")[0];
    let justify = document.getElementById("justify");
    
    switch(true){
        case (justify.value == "left"):
            container.style.justifyContent = "left";
            break;
        case (justify.value == "center"):
            container.style.justifyContent = "center";
            break;
        case (justify.value == "right"):
            container.style.justifyContent = "right";
            break;
    }
}


//change all flex-item's colors
function ChangeColor(){

    let color = document.getElementById("color");
    let itens = document.getElementsByClassName("flex-item");
    
    for(let i=0; i<itens.length; i++){
        itens[i].style.backgroundColor = color.value;
    }
}

//change a single flex-item color
window.onload = ChangeSingleBlockColor();
function ChangeSingleBlockColor(){

    document.querySelectorAll('.flex-item').forEach(item => {
        item.children[1].addEventListener("change", () => {
            item.style.backgroundColor = item.children[1].value;
        });
    });
}

window.onload = ChangeSingleBlockOrder();
function ChangeSingleBlockOrder(){
    document.querySelectorAll('.flex-item').forEach(item => {
        item.children[0].addEventListener("change", () => {
            item.style.order = item.children[0].value;
        });
    });
}


function SaveLayoutToLocalStorage(){

    let container = querySelectorAll(".flex-container");
    let itens = querySelectorAll(".flex-item");

    let containerData = {
        lenght : itens.length,
        order : container.style.flexFlow,
        justify: container.style.justifyContent,
        color : document.getElementById("color").value
    }
    
    let data = [];
    for(let item in itens){
        let itemInfo = {
            text : item.textContet,
            inputOrder 
        }
    }
}
/*

window.onload = ChangeSingleBlockRandom();
function ChangeSingleBlockRandom(){

    document.querySelectorAll('.flex-item').forEach(item => {
        item.addEventListener("click", () => {
                lista.push(item);
                let rc = [Math.floor(Math.random()*256), Math.floor(Math.random()*256), Math.floor(Math.    random()*256)];
                item.style.backgroundColor = `rgb(${rc[0]}, ${rc[1]}, ${rc[2]})`
        })
    })
}
*/