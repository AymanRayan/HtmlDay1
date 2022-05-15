//part1 lab1 Login
function logIn(){
    let userName = prompt("Enter The User name.");
    let password = prompt("Enter the Password.");
    if(userName != "admin"){
        alert("the username is not correct.");
    }else if (password != "421$$"){
        alert("the password is not correct.");
    }else{
        alert("Welcome login Success");
    }
}
logIn();

//part1 Lab2 Calc
function Calc(){
    let firstNo =parseInt(prompt("Enter the first number."));
    let oper =prompt("Enter an operation (sum ,multi,subtract, division,moduls)");
    let secoNo =parseInt(prompt("Enter the Secound number."));
    result = doOperant(firstNo,secoNo,oper);
    alert(`the result equal ${result}`);
    //Part1 Bonus
    do{
        oper =prompt("Enter an operation (sum ,multi,subtract, division,moduls)");
        if(oper == null){
            break;
        }
        secoNo =parseInt(prompt("Enter the number."));
        result = doOperant(result,secoNo,oper);
        alert(`the result equal ${result}`);
    }while(true)
}
function doOperant(first,secound,op){
    let result;
    switch (op){
        case "sum":
            result =first + secound;
            break;
        case "multi":
            result = first * secound;
            break;
        case "subtract":
            result = first - secound;
            break;
        case "division":
            result = first / secound;
            break;
        case "moduls":
            result = first % secound;
            break;            
    }
    return result
}
Calc();


//Part1 Lab1
function sum(){
let noOfNumbers=parseInt(prompt("How many numbers you want to get sum of?"));
let numbers=[];
for(let i = 0; i < noOfNumbers; i++){
    let no = parseInt(prompt(`Enter no ${i +1}`));
    numbers.push(no);
}
let sum = 0;
let average = 0;
for(let j = 0; j < numbers.length; j++){
   sum += numbers[j];
}
average = sum / numbers.length;
alert(`The sum of these numbers is ${sum} ,The Average of them is ${average}`);
}
sum();

//part2 Lab2 phonebook different from the lecture.
let phonebook = {
    contacts:[],
    addNew : function(n,p){
        this.contacts.push({name:n,phone:p});
        alert(`${n} added Successfully to the PhoneBook.`);
    },
    search : function(na){
        this.contacts.forEach(element => {
            if(element.name == na){
                alert(`The Number of ${element.name} is ${element.phone}.`);
            }else{
                alert(`There is no contacts for the name ${na} try add to add new.`)
            }
        });
    }
}
function theDirectory(){
    do{
        let answer= prompt("Do you want to ADD new Contact or Search for existing? (add / find)");
        if (answer == "add"){
            let name = prompt("Enter The Name.");
            let phone = prompt("Enter the Phone.");
            phonebook.addNew(name,phone);
            console.log(phonebook.contacts);
        }else if(answer == "find"){
           let name = prompt("Enter the name.");
           phonebook.search(name);
           console.log(phonebook.contacts);
        }
        if(answer == null){
             break;
         }
    }while(true);
}
theDirectory();

//part2 Bonus
function areaCala(){
    let name =prompt("Enter the name of the shape ..\n-Circle.\n-Triangle.\n-Square.\n-Rectangle.\n-Parallelogram.\n-Trapezium.\n-Ellipse.");
    name = name.charAt(0).toUpperCase() + name.slice(1);
    switch (name){
        case "Circle":
            circle();
            break;
        case "Trapezium":
            Trapezium();
            break;
        case "Triangle":
            triangle();
            break;
        case "Square":
            square();
            break;
        case "Rectangle":
            Rectangle();
            break;
        case "Parallelogram":
            Parallelogram();
            break;
        case "Ellipse":
            Ellipse();
            break;
    }
}
function circle(){
    let radius = parseInt(prompt("Enter the Radius of the Circle"));
    let area = 3.14 * radius *radius;
    alert(`Area for the circle with radius ${radius} is ${area}m2`);
}
function square(){
    let side = parseInt(prompt("Enter the Side f the square"));
    let area = side * side;
    alert(`Area for the square with side ${side} is ${area}m2`);
}
function triangle(){
    let base = parseInt(prompt("Enter the base of the triangle"));
    let height = parseInt(prompt("Enter the height of the triangle"));
    let area = 0.5 * base * height;
    alert(`Area for the Triangle with base and height are ${base} ,${height} is ${area}m2`);
}
function Rectangle(){
    let length = parseInt(prompt("Enter the lenght of the rectangle"));
    let width = parseInt(prompt("Enter the width of the rectangle"));
    
    let area =  length * width;
    alert(`Area for the Rectangle with length and height are ${length} ,${width} is ${area}m2`);
}
function Parallelogram(){
    let base = parseInt(prompt("Enter the base of the Parallelogram"));
    let height = parseInt(prompt("Enter the vertical height of the Parallelogram"));
    
    let area = 0.5 * base * height;
    alert(`Area for the Parallelogram with base and height are ${base} ,${height} is ${area}m2`);
}
function Trapezium(){
    let first = parseInt(prompt("Enter the first parallel side of the Trapezium"));
    let secound = parseInt(prompt("Enter the secound parallel side of the Trapezium"));
    let height = parseInt(prompt("Enter the vertical height of the Trapezium"));
   
    let area = (0.5 *(first + secound ) )* height;
    alert(`Area for the Trapezium  is ${area}m2`);
}
function Ellipse(){
    let minor = parseInt(prompt("Enter the minor axis of the Ellipse"));
    let major = parseInt(prompt("Enter the major axis of the Ellipse"));
   
    let area = 3.14 * 0.25 * minor * major;
    alert(`Area for the Ellipse with minor and major axis are ${minor} ,${major} is ${area}m2`);
}
areaCala()