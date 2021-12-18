import {
    name,
    description,
    imgSrc,
    cardName,
    cardDescription,
    cardImg
} from './selectors.js';

function setValue() {
    cardName.innerHTML = name.value;
    cardDescription.innerHTML = description.value;
    cardImg.src = imgSrc.value;
}

export default {setValue};