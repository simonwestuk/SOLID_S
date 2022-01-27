

public static class Persistence
{
    public static string Load(string filename)
    {
        return File.ReadAllText(filename);
    }

    public static void Save(ToDoList list)
    {
        File.WriteAllText($"{list.Name}.txt", list.ToString());
    }

}