const starWarsCharac = [{
    "name": "Luke Skywalker",
    "height": "172",
    "mass": "77",
    "hair_color": "blond",
    "skin_color": "fair",
    "eye_color": "blue",
    "birth_year": "19BBY",
    "gender": "male"
}, {
    "name": "C-3PO",
    "height": "167",
    "mass": "75",
    "hair_color": "n/a",
    "skin_color": "gold",
    "eye_color": "yellow",
    "birth_year": "112BBY",
    "gender": "n/a"
}, {
    "name": "R2-D2",
    "height": "96",
    "mass": "32",
    "hair_color": "n/a",
    "skin_color": "white, blue",
    "eye_color": "red",
    "birth_year": "33BBY",
    "gender": "n/a"
}, {
    "name": "Darth Vader",
    "height": "202",
    "mass": "136",
    "hair_color": "none",
    "skin_color": "white",
    "eye_color": "yellow",
    "birth_year": "41.9BBY",
    "gender": "male"
}, {
    "name": "Leia Organa",
    "height": "150",
    "mass": "49",
    "hair_color": "brown",
    "skin_color": "light",
    "eye_color": "brown",
    "birth_year": "19BBY",
    "gender": "female"
}, {
    "name": "Obi-Wan Kenobi",
    "height": "182",
    "mass": "77",
    "hair_color": "auburn, white",
    "skin_color": "fair",
    "eye_color": "blue-gray",
    "birth_year": "57BBY",
    "gender": "male"
}, {
    "name": "Yoda", 
    "height": "66", 
    "mass": "17", 
    "hair_color": "white", 
    "skin_color": "green", 
    "eye_color": "brown", 
    "birth_year": "896BBY", 
    "gender": "male"
}, {
    "name": "Palpatine", 
    "height": "170", 
    "mass": "75", 
    "hair_color": "grey", 
    "skin_color": "pale", 
    "eye_color": "yellow", 
    "birth_year": "82BBY", 
    "gender": "male"
}];

let nonGender = starWarsCharac.filter(charac => charac.gender === 'n/a');
console.log(nonGender);

let massLessThan30 = starWarsCharac.find(charac => parseInt(charac.mass) <= 30);
console.log(massLessThan30);

let meanHeight = (starWarsCharac
    .map(charac => charac.height)
    .reduce((a, b) => parseInt(a) + parseInt(b)) / starWarsCharac.length).toFixed(2);

console.log(meanHeight);

let meanMass = (starWarsCharac
    .map(charac => charac.mass)
    .reduce((a, b) => parseInt(a) + parseInt(b)) / starWarsCharac.length).toFixed(2);

console.log(meanMass);

let firstFemale = starWarsCharac.find(charac => charac.gender === 'female');
console.log(firstFemale);

let heightHigherThan150 = starWarsCharac.filter(charac => parseInt(charac.height) > 150);
console.log(heightHigherThan150);

