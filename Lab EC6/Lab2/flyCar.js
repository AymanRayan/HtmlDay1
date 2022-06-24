import {Car} from './car.js';

class flyCar extends Car{
    constructor(model,year,canFly = true ){
        super(model,year);
        this.canFly=canFly;
    }
}

export {flyCar};