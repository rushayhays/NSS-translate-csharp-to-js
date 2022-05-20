// Put your code here

const names = [
    "Nashville", "Hong Kong", "The back yard", "Earth",
     "London", "The mall", "Ryman Auditorium", "The Great Wall of China"
];
 
console.log("All Place Names");

function namePrinter(arrayName){
    for (const name of arrayName) {
    console.log(name);
    }

}

namePrinter(names)

console.log("--------------------------------------------")
console.log("'The' Place Names")


function nameLooker(){
    let theNames = [];
    for (const name of names){
        if(name.startsWith("The")){
            theNames.push(name)
        }
    }
    namePrinter(theNames)
}

nameLooker();



