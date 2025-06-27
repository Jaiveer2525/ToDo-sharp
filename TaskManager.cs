using System.Text.Json;

class TaskManager
    {
        public TaskManager()
        {
            ReadFile();
        }

        private const string fileName = "todo.json";
        private List<TaskItem> tasks = [];

        int id;
        public void Add (string desc){
            id = tasks.Count != 0 ? tasks.Max(tasks => tasks.Id) + 1 : 1;
            if (desc == "null"){
                Console.WriteLine("No description Provied, Createing New Empty Task");
                tasks.Add(new TaskItem { Id = id });
            }else{
                //Console.WriteLine("task = " + desc);
                tasks.Add(new TaskItem {Id = id , Desc = desc});
            }
            WriteFile();
            Console.WriteLine("Task added successfully.");
        }

        public void Done (int id) {
            foreach (var item in tasks)
            {
                if (item.Id == id){
                    if (item.IsDone == true){
                        Console.WriteLine("The Task is already marked as Done!");
                    }else
                    {
                        item.IsDone = true;
                        WriteFile();
                        Console.WriteLine("Item has been marked Done.");
                    }
                }
            }
        }
        public void List () {
            if (tasks.Count == 0){
                Console.WriteLine("The ToDo is empty!");
            }else
            {
                Console.WriteLine("Id\tIsDone\tDescription");
                foreach (var t in tasks){
                    Console.WriteLine(t.Id + "\t" + t.IsDone + "\t" + t.Desc);
                } 
            }
        }
        public void Delete (int id) {
            tasks.RemoveAll(t => t.Id == id);
            WriteFile();
            Console.WriteLine("Task Deleted Successfully");
        }

        private void ReadFile () {
            if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            tasks = JsonSerializer.Deserialize<List<TaskItem>>(json, TaskItemJsonContext.Default.ListTaskItem) ?? [];
        }
        }
        private void WriteFile () {
            var json = JsonSerializer.Serialize(tasks, TaskItemJsonContext.Default.ListTaskItem );
            File.WriteAllText(fileName, json);
        }
    }