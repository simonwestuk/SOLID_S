
public static class ManageItem
{
    public static void AddItem(ToDoList list, ToDoItem item)
    {
        list.items.Add(item);
    }

    public static void RemoveItem(ToDoList list, ToDoItem item)
    {
        list.items.Remove(item);
    }
}