//Array predefined methods

/*1- entries() ==> create/return an array iterator with key and value*/ 
const fruits = ["Banana", "Orange", "Apple", "Mango"];
const f = fruits.entries();

for (let x of f) {
  console.log(x);
}
/*2-every() execute fun for each array element return true if true for all and false if one of them was false*/
let ages = [32, 33, 16, 40];

console.log(ages.every(checkAge));

function checkAge(age) {
  return age > 18;
}
/*3-findIndex() execute function for each element return position of first element that passes the test and -1 if there is no match*/
ages = [3, 10, 18, 20];

console.log(ages.findIndex(checkAge));

function checkAge(age) {
  return age > 18;
}
/*4-Array.from() return array from any object with lenght*/
console.log(Array.from("Ayman"));
/*5-Array.isArray() check if an object is an array*/
let text = "W3Schools";
let result = Array.isArray(text);
console.log(result);
/*6-includes() true if the array contain the element and false if not*/
const fru = ["Banana", "Orange", "Apple", "Mango"];
console.log(fru.includes("Mango"));
/*7-reverse() reverse the order of the element in an array and overwrite it*/
let no =[1,2,3,4,5];
console.log(no.reverse());
/*8-some() check if any array elements pass a test provied as function*/
console.log(ages.some(checkAge));
/*9-valueOf() return value of the array */
const myArr = fru.valueOf();
console.log(myArr);
/*10-copyWithin() copy array element to another position in array .. overwrite existing values*/
console.log(fru);
fru.copyWithin(2,0);//copy first 2 ele to last 2 element
console.log(fru);

/////////////////////////
//Object predefined methods


/*1-Object.assign() cloning an object or merge object with some properties*/
tar = {na: "Ayman"};
src = {age: 26};
newObj = Object.assign(tar,src);

/*2-Object.freeze() prevent new properties and values to be added*/
let obj = {na : "ay"};
Object.freeze(obj);
obj.na = "ry";
console.log(obj);
/*3-Object.keys() return an array of keys/properties */
let o = { 
    na: "a",
    ag: "2",
    po: "dev"
}
console.log(Object.keys(o));

/*4-Object.values() return an array of values*/
console.log(Object.values(o));
/*5-Object.entries() return array of all keys and values */
console.log(Object.entries(o));
/*6-Object.preventExtensions()  prevent adding properties*/
/*7-Object.defineProperty() add a property */
console.log(o);
Object.defineProperty(o,"ye",{value: "1996"});
console.log(o);
Object.preventExtensions(o);
//Object.defineProperty(o,"lo",{value: "alex"}); ////return error


/*8-Object.isFrozen() return true if the obj frozen */
console.log(Object.isFrozen(o));
/*9-Object.isExtensible() return true if can add property*/
console.log(Object.isExtensible(o));
/*10-Object.getOwnPropertyDescriptor()  access properties data return as object*/
console.log(Object.getOwnPropertyDescriptor(o,"na"));