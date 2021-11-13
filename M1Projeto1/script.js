
function Add(){
    
    let newInput = document.querySelectorAll("input")[0];

    NewRow(newInput.value);
    newInput.value = "";
    SaveListToLocalStorage();
}

function NewRow(newInput, done=false){

    if(newInput != ""){
        let newRow = document.createElement("li");
        newRow.className = "list-row";
    
        let newText = document.createElement("p");
        newText.className = "to-do";
        newText.textContent = newInput;
    
        if(done){
            newText.style.textDecoration = "line-through";
        }

        let newCheckBox = document.createElement("input");
        newCheckBox.className = "checkbox";
        newCheckBox.type = "checkbox";
        newCheckBox.checked = done;
        
        let newDeleteBtn = document.createElement("i");
        newDeleteBtn.className = "fas fa-trash fa-2x";
    
        newRow.appendChild(newText);
        newRow.appendChild(newCheckBox);
        newRow.appendChild(newDeleteBtn);

        document.querySelectorAll(".list")[0].appendChild(newRow);
    };


};

window.onload = SaveOnListChange();
function SaveOnListChange(){

    
    document.querySelectorAll('.list')[0].addEventListener("change", () => {
        
        let checkBoxes = document.querySelectorAll('.checkbox');
        let rows = document.querySelectorAll('.list-row');
        for(let i=0; i<checkBoxes.length; i++){
            
            if(checkBoxes[i].checked){
                rows[i].children[0].style.textDecoration = "line-through";
            }

            else{
                rows[i].children[0].style.textDecoration = "none";

            }
        }

        SaveListToLocalStorage();
    })

  // how to remove row ??
}

let toDoList = JSON.parse(localStorage.getItem("to-do-list"));
function SaveListToLocalStorage(){
    
    let list = document.querySelectorAll(".to-do");
    let checkBoxes = document.querySelectorAll(".checkbox");
    let toDoList = [];


    for(let i=0; i<list.length; i++){
        
        let toDo = {
            text : list[i].textContent,
            done : checkBoxes[i].checked
        }

        toDoList.push(toDo);
        console.log(toDoList);

    }
    
    localStorage.setItem("to-do-list", JSON.stringify(toDoList));
}

window.onload = LoadListFromLocalStorage();
function LoadListFromLocalStorage(){

    let toDoList = JSON.parse(localStorage.getItem("to-do-list"));

    if(toDoList == null){
        return;
    }

    for(let i=0; i<toDoList.length; i++){

        NewRow(toDoList[i].text, toDoList[i].done);
    }
}
