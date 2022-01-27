
public class ToDoList
{
    public List<ToDoItem> items;
    public string Name { get; set; }
    public ToDoList(string name)
    {
        items = new List<ToDoItem>();
        Name = name;
    }
 
    public override string ToString()
    {
        return string.Join("\n", items);
    }

}
