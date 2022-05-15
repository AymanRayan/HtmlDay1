//Bounce task
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

//theDirectory();
