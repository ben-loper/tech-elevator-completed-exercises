// add pageTitle
/**
 * pageTitle: {string} Title for the page
 */
const pageTitle = `My Shopping List`;

// add groceries
/**
 * groceries: {Array} Items in the shopping list
 */
const groceries = [`Milk`, `Hamburger`, `Nachos`, `Bread`, `Beans`, 
                    `Dog Food`, `Cereal`, `Shoes`, `Pop`, `Chips`];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {

  let title = document.getElementById(`title`);

  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {

  let ul = document.querySelector('.shopping-list ul');

  groceries.forEach((groceryItem) => {
    let li = document.createElement('li');

    li.appendChild(document.createTextNode(groceryItem));

    ul.appendChild(li);
  });
}

/**
 * This function will be called wh4en the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  
  let ulNode = document.querySelector('ul');

  ulNode.childNodes

  let groceryItems = document.querySelectorAll('.shopping-list ul li');

  groceryItems.forEach((element) => {
    element.classList.add('completed');
  });

}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
