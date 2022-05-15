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
//logIn();

//part1 Lab2 Calc
function Calc(){
    let firstNo =parseInt(prompt("Enter the first number."));
    let oper =prompt("Enter an operation (sum ,multi,subtract, division,moduls)");
    let secoNo =parseInt(prompt("Enter the Secound number."));
    result = doOperant(firstNo,secoNo,oper);
    alert(`the result equal ${result}`);
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
//Calc();

//Part1 Lab1
let noOfNumbers=parseInt(prompt("How many numbers you want to get sum of?"));


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
//theDirectory();
