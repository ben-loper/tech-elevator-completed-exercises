/** 
 * Given the month of the year, day of the month, and a hemisphere, determines if it
 * is summer in that location
 * @param {int} month is the month of the year
 * @param {int} day is the day of the month, defaults to 1
 * @param {string} hemisphere is the hemisphere the of the location is in
 * @returns {boolean} returns true if it is summer, false if it is not
 */
function isSummer(month, day = 1, hemisphere = 'northern') {
  if (month === 7 || month === 8) {
    return hemisphere === 'northern';
  } else if (month === 6 && day >= 20) {
    return hemisphere === 'northern';
  } else if (month === 9 && day <= 20) {
    return hemisphere === 'northern';
  } else if (month === 1 || month === 2) {
    return hemisphere === 'southern';
  } else if (month === 12 && day >= 20) {
    return hemisphere === 'southern';
  } else if (month === 3 && day <= 20) {
    return hemisphere === 'southern';
  } else {
    return false;
  }
}

/**
 * Write a function called isAdmitted. It will check entrance
 * scores and return true if the students is admitted and
 * false if rejected. It takes three parameters:
 *
 *     * gpa
 *     * satScore (optional)
 *     * recommendation (optional)
 *
 * We admit them--return true--if:
 * gpa is above 4.0 OR
 * SAT score is above 1300 OR
 * gpa above 3.0 and they have a recommendation OR
 * SAT score is above 1200 and they have a recommendation
 * OTHERWISE reject it
 *
 * @param {number} gpa the GPA of the student, between 4.2 and 1.0
 * @param {number} [satScore=0] the student's SAT score
 * @param {boolean} [recommendation=false] does the student have a recommendation
 * @returns {boolean} true if they are admitted
 */

function isAdmitted(gpa, satScore = 0, recommendation = false) {

  let result = false;

  if (gpa > 4.0 || satScore > 1300 || (gpa > 3.0 && recommendation === true) || (satScore > 1200 && recommendation)) {
    result = true;
  }

  return result;
}


/**
 * Write a function so that it takes an anonymous function and
 * uses that in `unfilteredArray` filter function. Return the result.
 *
 * @param {function} filterFunction the function to filter with
 * @returns {number[]} the filtered array
 */
let unfilteredArray = [1, 2, 3, 4, 5, 6];

function useParameterToFilterArray(filterFunction) {

  return unfilteredArray.filter((element) => {

    return filterFunction(element);

  });
}

/**
 * Write a function called makeNumber to take two strings
 * of digits, concatenate them together, and then return
 * the value back as a number.
 *
 * So if two strings are passed in "42293" and "443", then this function
 * should return thnumber 42293443.
 *
 * @param {string} first the first string of digits to concatenate
 * @param {string} [second=''] the second string of digits to concatenate
 * @returns {number} the resultant number
 */

function makeNumber(first, second = '') {
  let result = first + second;

  return parseInt(result);
}

/**
 * Write a function that takes an unknown number of parameters
 * and adds them all together. Return the result.
 *
 * @param {...number} num a series of numbers to add together
 * @returns {number} the sum of all the parameters (or arguments)
 */
function addAll() {
  let result = 0;

  for (let i = 0; i < arguments.length; i++) {
    result += arguments[i];
  }

  return result;
}

/*
 * Write and document a function called makeHappy that takes
 * an array and prepends 'Happy ' to the beginning of all the
 * words and returns them as a new array. Use the `map` function.
 */

/**
 * @param {string[]} givenArray a series of strings to append 'Happy' to the beginning of each string
 * @returns {sring[]} the array with 'Happy' prepended
*/
function makeHappy(givenArray){
  
  return givenArray.map( (element) => {

    return 'Happy ' + element;

  });
}


/** 
 * Write and document a function called getFullAddressesOfProperties
 * that takes an array of associative arrays containing the
 * following keys:
 *     * streetNumber
 *     * streetName
 *     * streetType
 *     * city
 *     * state
 *     * zip
 *
 * and returns an array of strings that turns the associative array
 * into mailing addresses in the form of:
 *     streetNumber streetName streetType city state zip
 *
 * Use `map` and an anonymous function.
 * 
 * @para {associative array[]} associativeArray is the array of associative arrays of addresses
 * @returns {string[]} an array of strings with the properties of each address
 */


function getFullAddressesOfProperties(associativeArray){

  return associativeArray.map((element) => {

    let fullAddressArray = [];

    for(let index in element){
      if(index === 'streetNumber'){
        fullAddressArray[0] = element[index];
      }  
      else if( index == 'streetName'){
        fullAddressArray[1] = element[index];
      }
      else if( index == 'streetType'){
        fullAddressArray[2] = element[index];
      }
      else if( index == 'city'){
        fullAddressArray[3] = element[index];
      }
      else if( index == 'state'){
        fullAddressArray[4] = element[index];
      }
      else if( index == 'zip'){
        fullAddressArray[5] = element[index];
      }
    }

    return fullAddressArray.reduce((fullAddress, addressPiece) => {

      return fullAddress + ` ${addressPiece}`;
    })

  });

}


/*
 * Create and document a function called findLargest.
 *
 * Using `forEach`, find the largest element in an array.
 * It should work for strings and numbers.
 */

 function findLargest(collection){
   
    let largestValue = collection[0];

      collection.forEach((element) => {
        if(element > largestValue){
          largestValue = element;
        }
      });

    return largestValue;
 }

/*
 * CHALLENGE
 * Create and document a function called getSumOfSubArrayValues.
 *
 * Take an array of arrays and add up all sub values and return
 * the sum. For instance, if you got this array as a parameter:
 * [
 *   [1, 2, 3],
 *   [2, 4, 6],
 *   [5, 10, 15]
 * ];
 *
 * You would return 48. To do this, you will use two nested `reduce`
 * calls with two anonymous functions.
 *
 * Read the tests to verify you have the correct behavior.
 */
