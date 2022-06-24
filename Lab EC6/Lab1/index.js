let numbers = [50,60,70,25,1,30,11,10,1,2,3,5,8,10,15]

//ascending
numbers.sort((a,b)=>{
    return a - b;
})
console.log(numbers)
//descending
numbers.sort((a,b)=>{
    return b - a;
})
console.log(numbers);
//filter
/*numbers=numbers.filter( (i) => {
    return i > 50;
})*/
console.log(numbers);
//max
console.log(Math.max(...numbers));
//min
console.log(Math.min(...numbers));
//new array
let newarr =Array.from(numbers, i => i * 5);
console.log(newarr);
let ball = document.getElementById('Ball');


//Ball Class
function Ball(leftP =10 , topP =10 ,color ='blue',iterate = 10){
    if(this.constructor.name == 'Window')
    throw new Error ("The ball is class not a function")
    this.color = color;
    this.leftP = leftP;
    this.topP = topP;

    this.theBall = document.createElement('div');
    this.theBall.style.borderRadius ='50%';
    this.theBall.style.width ='200px';
    this.theBall.style.height='200px';
    this.theBall.style.background =this.color;
    this.theBall.style.position="absolute";
    this.theBall.style.top = `${this.topP}px`;
    this.theBall.style.left =`${this.leftP}px`;
    ball.appendChild(this.theBall);
    this.fallingDown = function () {
      let ballInterval=setInterval(()=>{
            this.theBall.style.top = `${this.topP +=iterate}px`;
            this.theBall.style.left =`${this.leftP +=iterate}px`;
            if(this.topP > (innerHeight - 200)){//inner height - ball height
                clearInterval(ballInterval);
            } 
        },1000)  
    }
}
let b1 = new Ball(0 ,0,'blue',40);
let b2 = new Ball(10,30,'red');
let b3 = new Ball(50,50,'yellow',60);
b1.fallingDown();
b2.fallingDown();
b3.fallingDown();
