using System;
using System.Collections.Generic;
using System.Linq;

namespace CybersecurityChatbotGUI
{
    public class TaskAssistant
    {
        public List<TaskItem> Tasks { get; } = new List<TaskItem>();

        // Replaces ChatLogic's task methods
        public void AddTask(string title, string description, DateTime? reminderDate = null)
        {
            Tasks.Add(new TaskItem(title, description, reminderDate));
        }

        public void DeleteTask(TaskItem task) => Tasks.Remove(task);

        public void ToggleTaskCompletion(TaskItem task) => task.IsCompleted = !task.IsCompleted;

        // Optional: For reminders
        public List<TaskItem> GetDueTasks() =>
            Tasks.Where(t => !t.IsCompleted && t.ReminderDate <= DateTime.Now).ToList();
    }
}