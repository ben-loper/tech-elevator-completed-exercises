let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}


function addCompleteClickEventListenerUl() {

  const groceryList = document.querySelector('ul');

  groceryList.addEventListener('click', (event) => {
    
    if(!event.target.classList.contains('completed')){
      if(event.target.matches('li')){
        const li = event.target;
        const checkBox = li.lastElementChild;

        li.classList.add('completed');
        checkBox.classList.add('completed');
      }
      else if(event.target.matches('i')){
        const checkBox = event.target;
        const li = checkBox.parentNode;

        li.classList.add('completed');
        checkBox.classList.add('completed');
      }
  }    
  })
}

function addIncompleteClickEventListenerUl() {

  const groceryList = document.querySelector('ul');

  groceryList.addEventListener('dblclick', (event) => {
    
    if(event.target.classList.contains('completed')){
      if(event.target.matches('li')){
        const li = event.target;
        const checkBox = li.lastElementChild;

        li.classList.remove('completed');
        checkBox.classList.remove('completed');
      }
      else if(event.target.matches('i')){
        const checkBox = event.target;
        const li = checkBox.parentNode;

        li.classList.remove('completed');
        checkBox.classList.remove('completed');
      }
  }    
  })
}


function toggleAllEventListener(){
  
  const toggleAllBtn = document.querySelector('#toggleAll');

  toggleAllBtn.addEventListener('click', () => {

    const groceryItems = document.querySelectorAll('ul li');

    if(allItemsIncomplete === true){
      
      groceryItems.forEach((item) => {       
        if(!item.classList.contains('completed')){
          const checkBox = item.lastElementChild;
          item.classList.add('completed');
          checkBox.classList.add('completed');
        }  
      })

      allItemsIncomplete = false;
      toggleAllBtn.innerText = 'mark all incomplete';
    }
    else if(allItemsIncomplete === false){
      
      groceryItems.forEach((item) => {       
        if(item.classList.contains('completed')){
          const checkBox = item.lastElementChild;
          item.classList.remove('completed');
          checkBox.classList.remove('completed');
        }  
      })

      allItemsIncomplete = true;
      toggleAllBtn.innerText = 'mark all complete';
    }

  })

}

setPageTitle();
displayGroceries();
addCompleteClickEventListenerUl();
addIncompleteClickEventListenerUl();
toggleAllEventListener();



