//calculator

let mathOperators = document.getElementsByClassName("math");
let numbers = document.getElementsByClassName("number");
let dot = document.getElementById(".");
let clear = document.getElementById("clear");
let calculator = new Object;

function writeOnInput(input){
 
    document.getElementById("screen").value = "";
    document.getElementById("screen").value = input;
}

document.getElementById('9').onclick = function(){
    document.getElementById("screen").value = "";
 document.getElementById("screen").value = '9';
}
document.getElementById('8').onclick = function(){
    document.getElementById("screen").value = "";
    document.getElementById("screen").value = '8';
}
document.getElementById('7').onclick = function(){
    document.getElementById("screen").value = "";
    document.getElementById("screen").value = '7';
}
document.getElementById('6').onclick = function(){
    document.getElementById("screen").value = "";
    document.getElementById("screen").value = '6';
}
document.getElementById('5').onclick = function(){
    document.getElementById("screen").value = "";
    document.getElementById("screen").value = '5';
}
document.getElementById('4').onclick = function(){
    document.getElementById("screen").value = "";
    document.getElementById("screen").value = '4';
}
document.getElementById('3').onclick = function(){
    document.getElementById("screen").value = "";
    document.getElementById("screen").value = '3';
}
document.getElementById('2').onclick = function(){
    document.getElementById("screen").value = "";
    document.getElementById("screen").value = '2';
}
document.getElementById('1').onclick = function(){
    document.getElementById("screen").value = "";
    document.getElementById("screen").value = '1';
}
document.getElementById('0').onclick = function(){
    document.getElementById("screen").value = "";
    document.getElementById("screen").value = '0';
}

clear.onclick = function() {
    document.getElementById("screen").value = "";
}