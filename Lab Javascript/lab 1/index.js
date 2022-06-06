let firstName = prompt("What's your first name?");
let lastName=prompt("What's your last name?");
let con1=confirm(`Well , Is your full name is ${firstName} ${lastName}`);
let fullName = firstName +" "+ lastName;
if(con1){
    let birthYear = prompt(`Hello ${fullName}, Enter your birthYear`); 
    alert(`Welcome ${fullName} you are ${2022 - birthYear}years old`);
    document.write(`Welcome ${fullName} you are ${2022 - birthYear}years old`);
}
alert("Here it’s the first release of a calculator that only has a summation feature.");
let x =parseInt(prompt("Please Enter the first number."));
let y =parseInt(prompt("Please Enter the second number."));
let sum = x + y;
alert(`${x} + ${y} = ${x + y}`);


