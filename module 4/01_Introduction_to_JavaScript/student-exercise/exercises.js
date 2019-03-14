function sumDouble(x, y) {
    
    let result = x + y;
    
    // do logic here
    if(x === y){
        result *= 2;
    }
    // return result;
    return result;
}

function hasTeen(num1, num2, num3){

    let result = false;

    let numOfTeens = 0;

    let nums = [num1, num2, num3];

    nums.forEach(element => {
        if(element >= 13 && element <= 19){
            numOfTeens++;
        }
    });

    if(numOfTeens >= 1){
        result = true;
    }

    return result;
}

function lastDigit(num1, num2){

    let result = false;

    let x = num1.toString();
    let y = num2.toString();

    if(x[x.length - 1] == y[y.length - 1]){
        result = true;
    }

    return result;
}

function seeColor(word){
    
    let result = "";

    if(word.startsWith("red")){
        result = "red";
    } 
    else if (word.startsWith("blue")){
        result = "blue";
    }

    return result;
}

function oddOnly(nums){
    return nums.filter(checkOdd);
}

function checkOdd(num){
    return num % 2 !== 0;
}

function frontAgain(word){
    
    let result = false;
    
    let firstTwo = word[0] + word[1];
    let lastTwo = word[word.length - 2] + word[word.length -1];

    if(firstTwo === lastTwo){

        result = true;
    }

    return result;
}

function cigarParty(numOfCigars, isWeekend){

    result = false;

    if((numOfCigars >= 40 && numOfCigars <= 60) && !isWeekend){
        result = true;
    } 
    else if(numOfCigars >= 40 && isWeekend){
        result = true;
    }
    
    return result;
}

function fizzBuzz(num){

    let result = num;

    if(num % 3 == 0 && num % 5 == 0){
        result = "FizzBuzz";
    } 
    else if(num % 5 == 0){
        result = "Buzz";
    }
    else if(num % 3 == 0){
        result = "Fizz";
    }

    return result;
}

function filterEvens(nums){
    return nums.filter(checkEvens);
}

function checkEvens(num){
    return num % 2 == 0;
}

function filterBigNumbers(nums){
    return nums.filter(checkOver100);
}

function checkOver100(num){
    return num >= 100;
}

function filterMultiplesOfX(nums, num){

    let results = [];

    nums.forEach(element => {
        if(element % num == 0){
            results.push(element);
        }
    });

    return results;
}


function createObject(){

    let result = {
        firstName: "Ben",
        lastName: "Loper",
        age: 26
    };

    return result;
}