# ToDo-sharp

A simple CLI tool to create, list, mark done and delete tasks in json file. Written in C#. 


## Usage 
1. `ToDo-sharp list` Lists all the currently saved Tasks along with their ID number and completion status
```
$ ToDo-sharp list
Id	IsDone	Description
1	True	task1
2	False	task2
```

2. `ToDo-sharp add` Creates a new task, Prompts user for Description. Automatically assignes it an ID and marks completion status as `false` by default.
```
$ ToDo-sharp add
Enter the description of the task : task3
Task added successfully.
```

3. `ToDo-sharp done` Prompts for Task ID, Marks that Task as completed.
```
$ ToDo-sharp done
Enter the Id of the completed task : 3
Item has been marked Done.
```

4. `ToDo-sharp delete` Prompts for Task ID, Deletes the task from the ToDo-sharp list.
```
$ ToDo-sharp delete
Enter the Id of the task to be deleted : 3
```

5. `ToDo-sharp` Shows a short usage guide.
```
ToDo-sharp
ToDo app
Usage: list , add , done , delete
```