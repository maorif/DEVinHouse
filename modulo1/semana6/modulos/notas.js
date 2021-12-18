import { name, Mean } from "./calcula-media.js";

//Notas
let joao = [9.2, 8.5, 10.0];
let maria = [9.0, 8.8, 9.5];
let laura = [8.0, 7.8, 9.2];

let mediaJoao = Mean(joao);
document.getElementById("media").innerText = `${name}: ${mediaJoao}`;