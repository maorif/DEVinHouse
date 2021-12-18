class Plant{
    constructor(name){
        this.name = name;
        this.water = 50;
        this.alive = true;
    }

    waterPlant(waterSum){
        this.water += waterSum
        if(this.alive && this.water > 100){
            this.alive = false;
            console.log(`${this.name} is dead.`);        
        }

        else{
            console.log(`water level: ${this.water}%.`);
        }
    }

    plantStatus(){
        console.log(`water level: ${this.water}%\nalive: ${this.alive}`)
    }
}

const samambaia = new Plant('samambaia');
const bananeira = new Plant('bananeira');

samambaia.plantStatus();
