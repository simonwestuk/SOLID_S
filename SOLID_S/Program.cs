ToDoList shoppingList = new ToDoList("Shopping");

ManageItem.AddItem(shoppingList, new ToDoItem("Tuna"));
ManageItem.AddItem(shoppingList, new ToDoItem("Cat Food"));

Console.WriteLine(shoppingList);

Persistence.Save(shoppingList);

