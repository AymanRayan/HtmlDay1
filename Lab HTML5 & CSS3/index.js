function formSubmition(){
    let userName = document.getElementById("username").value;
    if(userName == ""){
        alert("Please enter your name")
    }else{
        localStorage.setItem("Username",userName);
    }
    return false;
}
(function Message(){
    let userna = localStorage.getItem("Username");
    if(userna != null){
        welcome(userna);
    }
})();

function welcome(name){
    let mess = document.getElementById("message");
    let h3 =document.createElement('h3');
    h3.textContent=`Welcome ${name}`;
    mess.append(h3);
}
