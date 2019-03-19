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


document.addEventListener("DOMContentLoaded", () => {
  
  setPageTitle();

  displayGroceries();

  // Register all of your event listeners here
  const groceryList = document.querySelector('ul');

  {

  }
  // Adds event listener to the grocery list Unordered List
  // to delegate to the grocery item
  {
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

  //Add double click event listener to the grocery list
  //to delegate to the grocery items
  {
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
 
  const toggleAllBtn = document.querySelector('#toggleAll');

  // Add event listener to the button for marking all grocery items to be complete
  // or incomplete
  {      
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
  

  const newItemBtn = document.querySelector("#new-item-btn");

  newItemBtn.addEventListener('click', ()=>{
    saveItem();
  })
});

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

function saveItem(){
  
  const itemNameNode = document.querySelector('#item-name');

  const itemName = itemNameNode.value;

  if(itemName !== ""){
    const li = document.createElement('li');
    li.innerText = itemName;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    
    const groceryList = document.querySelector('ul');

    groceryList.appendChild(li);

    itemNameNode.value = "";
  }

}

// setPageTitle();
// displayGroceries();
// // addCompleteClickEventListenerUl();
// // addIncompleteClickEventListenerUl();
// // toggleAllEventListener();



