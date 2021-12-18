//import countries from "./paises.js";
const countries = [{
    "name": "Afghanistan",
    "region": "Asia",
    "population": 38928341,
    "area": 652230.0
  }, {
    "name": "Brazil",
    "region": "Americas",
    "population": 212559409,
    "area": 8515767.0
  }, {
    "name": "China",
    "region": "Asia",
    "population": 1402112000,
    "area": 9640011.0
  }, {
    "name": "Egypt",
    "region": "Africa",
    "population": 102334403,
    "area": 1002450.0
  }, {
    "name": "Estonia",
    "region": "Europe",
    "population": 1331057,
    "area": 45227.0
  }, {
    "name": "India",
    "region": "Asia",
    "population": 1380004385,
    "area": 3287590.0
  }, {
    "name": "Malawi",
    "region": "Africa",
    "population": 19129955,
    "area": 118484.0
  }, {
    "name": "Poland",
    "region": "Europe",
    "population": 37950802,
    "area": 312679.0
  }, {
    "name": "Romania",
    "region": "Europe",
    "population": 19286123,
    "area": 238391.0
  }];

let popBiggerThan1kk = countries.filter(country => country.population > 100000000);
//console.log(popBiggerThan1kk);

let countryNames = countries.map(country => `Nome: ${country.name}, Região: ${country.region}`);
//console.log(countryNames);

let europeCountries = countries.filter(country => country.region === 'Europe');
let allEuropeCountries = countries.every(country => country.region === 'Europe'); // false
//console.log(europeCountries);

let meanEuropePop = Math.round(countries
    .filter(country => country.region === 'Europe')
    .map(country => country.population)
    .reduce((totalPop, popNow) => totalPop + popNow) / europeCountries.length);
console.log(meanEuropePop);

let firstAfrica = countries.find(country => country.region === 'Africa');
console.log(firstAfrica);