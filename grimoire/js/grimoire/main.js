//Some code to make spell books

console.log("Do you believe in magic?")
console.log("------------------------")


function transcribeSpell(spellName, booly, energyNum){
    const newSpell = {
        name:spellName,
        isEvil:booly,
        EnergyReqired: energyNum
    }
    return newSpell
}

function authorSpellBook(title, listOfSpellObjects){
    const newSpellBook = {
        title:title,
        spells:listOfSpellObjects
    }
    return newSpellBook;
}

function GetAllSpells(){
    let listOfAllSpells = []

    const spellOne = transcribeSpell("Turn enemy into a newt", true, 5.1)
    const spellTwo = transcribeSpell("Conjure some gold for a local charity", false,2.99)
    const spellThree = transcribeSpell("Give a deaf person the ability to heal",false,12.2)
    const spellFour = transcribeSpell("Make yourself emperor of the universe",true,100.0)
    const spellFive = transcribeSpell("Convince your relatives your political views are correct",false,2921.5)

    listOfAllSpells.push(spellOne)
    listOfAllSpells.push(spellTwo)
    listOfAllSpells.push(spellThree)
    listOfAllSpells.push(spellFour)
    listOfAllSpells.push(spellFive)

    return listOfAllSpells;
}

//Here we make some spellbooks
function MakeEvilSpellBook(listOSpells)
{
    let allEvilSpells = listOSpells.filter(spell => spell.isEvil);
    let evilBook = authorSpellBook("Evil Book", allEvilSpells)
    
    return evilBook;
}

function MakeGoodSpellBook(listOSpells)
{
    let allGoodSpells = listOSpells.filter(spell => !spell.isEvil);
    let goodBook = authorSpellBook("Good Book", allGoodSpells)
    
    return goodBook;
}

function displaySpellBook(bookObj){
    console.log(bookObj.title)
    for(let x=0; x < bookObj.spells.length; x++){
        console.log(bookObj.spells[x].name)
    }
}

const mySpellList = GetAllSpells();
const goodBook = MakeGoodSpellBook(mySpellList)
const evilBook = MakeEvilSpellBook(mySpellList)
displaySpellBook(goodBook);
console.log("")
displaySpellBook(evilBook);