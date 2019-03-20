

document.addEventListener('DOMContentLoaded', function() {


    {
        const loadButton = document.querySelector('.loadingButton');

        loadButton.addEventListener('click', ()=> {

            fetch('data/shopping-list.json')
                .then( (response) => {
                    return response.json();
                })
                .then( (json) => {

                    const shoppingList = document.querySelector('ul');

                    // Remove any existing shopping list items when the request is made
                    // to ensure no duplicates
                    while(shoppingList.firstChild) {
                        shoppingList.removeChild(shoppingList.firstChild);
                    }
                    
                    json.forEach(item => {               
                        let node = document.createElement('li');
                        node.appendChild(document.createTextNode(item.name));
                        if(item.completed){
                            node.className = "completed";
                        }

                        shoppingList.appendChild(node);
                        
                    });
                })
        })
    }
})