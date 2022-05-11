do{
    do{
      var age =parseInt(prompt("Please enter Your age."));
    }while(age <= 0 );
    let status;
    switch(true){
        case (age >= 1 && age <= 10):
            status = "Child";
            break;
        case (age >= 11 
            && age <= 18):
            status = "Teenager";
            break;
        case (age >= 19 && age <= 50):
            status = "Grown up";
            break;
        case (age > 50):
            status = "Old";
            break;     
    
    }
    if (isNaN(age)){
        break;
    }
    alert(`The status for ${age}years old, is ${status}`);  
}while(true);
    

let str = prompt("Please Enter the string");
let count = 0;
for (let i = 0; i <= str.length -1; i ++){
    if(str.charAt(i) == "a" || str.charAt(i) == "e" || str.charAt(i) == "o" || str.charAt(i) == "i" || str.charAt(i) == "u"){
        count += 1;
    }
}
alert(`The Number of Vowels in this String ${str} equal ${count} `);

let hour;
do{
     hour =prompt("enter the clock");
}while(hour < 0 || hour > 24);

let clock , st;
switch (true){
    case hour > 12:
        clock = hour - 12;
        st = "PM";
        break;
    case hour == 12:
        clock = hour;
        st =  "pM";
        break;
    case hour == 0:
        clock = 12;
        st = "AM";
        break;
    default:
    clock = hour;
    st = "AM";           
}
alert(`The clock is ${clock}${st}`);

