using System;
using System.Collections.Generic;

class Task
{
    public int TaskId { get; set; }
    public string Description { get; set; }
}

class TaskManager
{
    private List<Task> taskList;

    public TaskManager()
    {
        taskList = new List<Task>();
    }

    public void AddTask(Task task)
    {
        taskList.Add(task);
    }

    public void RemoveTask(int taskId)
    {
        taskList.RemoveAll(task => task.TaskId == taskId);
    }

    public void DisplayTasks()
    {
        Console.WriteLine("Tasks:");
        foreach (var task in taskList)
        {
            Console.WriteLine($"TaskId: {task.TaskId}, Description: {task.Description}");
        }
    }
}

class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class UserManager
{
    private List<User> userList;

    public UserManager()
    {
        userList = new List<User>();
    }

    public void AddUser(User user)
    {
        userList.Add(user);
    }

    public void RemoveUser(int userId)
    {
        userList.RemoveAll(user => user.Id == userId);
    }

    public User FindUserById(int userId)
    {
        return userList.Find(user => user.Id == userId);
    }

    public void DisplayUsers()
    {
        Console.WriteLine("Users:");
        foreach (var user in userList)
        {
            Console.WriteLine($"UserId: {user.Id}, Name: {user.Name}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Тестування завдання 1
        TaskManager taskManager = new TaskManager();
        taskManager.AddTask(new Task { TaskId = 1, Description = "Complete assignment" });
        taskManager.AddTask(new Task { TaskId = 2, Description = "Submit report" });
        taskManager.DisplayTasks();
        taskManager.RemoveTask(1);
        taskManager.DisplayTasks();

        // Тестування завдання 2
        UserManager userManager = new UserManager();
        userManager.AddUser(new User { Id = 1, Name = "Nastia Damian" });
        userManager.AddUser(new User { Id = 2, Name = "Anastasiia" });
        userManager.DisplayUsers();
        userManager.RemoveUser(1);
        userManager.DisplayUsers();
        User foundUser = userManager.FindUserById(2);
        if (foundUser != null)
        {
            Console.WriteLine($"Found user: UserId: {foundUser.Id}, Name: {foundUser.Name}");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }
}
