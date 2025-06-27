class Program
{
    static public void Main(string[] args)
    {
        var taskmanager = new TaskManager();
        if (args.Length == 0)
        {
            Console.WriteLine("ToDo app\nUsage: list , add , done , delete");
        }
        else
        {
            switch (args[0].ToLower())
            {
                case "add":
                    Console.Write("Enter the description of the task : ");
                    string desc = Console.ReadLine() ?? "";
                    desc = string.IsNullOrEmpty(desc) ? "null" : desc;
                    //Console.WriteLine(desc);
                    taskmanager.Add(desc);
                    break;

                case "list":
                    taskmanager.List();
                    break;

                case "done":
                    Console.Write("Enter the Id of the completed task : ");
                    int done_id = Convert.ToInt32(Console.ReadLine());
                    taskmanager.Done(done_id);
                    break;

                case "delete":
                    Console.Write("Enter the Id of the task to be deleted : ");
                    int del_id = Convert.ToInt32(Console.ReadLine());
                    taskmanager.Delete(del_id);
                    break;

                default:
                    Console.WriteLine("Unknown Comand");
                    break;
            }
        }

    }
}
