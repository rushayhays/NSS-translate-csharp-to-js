//code goes here
console.log("Let's roll some dice, baby!")
console.log("---------------------------")

function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function getStringNum(num){
    switch (num) {
        case 1:
            dieString = "one";
            break;
        case 2:
            dieString = "two";
            break;
        case 3:
            dieString = "three";
            break;
        case 4:
            dieString = "four";
            break;
        case 5:
            dieString = "five";
            break;
        case 6:
            dieString = "six";
            break;
    }
    
    return dieString;
}


function createDie(num) {
    const dieNum = getStringNum(num);
    return {
        numberVal: num,
        stringVal: dieNum
    }
}

function Roll() {
    const dieValue = getRandomInt(1,6);
    const die = createDie(dieValue);
    return die;
}

for (let i = 0; i < 10; i++)
{
    const die1 = Roll();
    const die2 = Roll();

    let message = `${die1.stringVal} + ${die2.stringVal} = ${die1.numberVal + die2.numberVal}`;
    if (die1.numberVal == die2.numberVal)
    {
        message += " DOUBLES!";
    }

    console.log(message);
}