using System;

namespace TaskFlow.Models
{
    public enum TaskStatus
    {
        Pendiente,
        EnProgreso,
        Completada
    }

    public class TaskItem
    {
        public int Id { get; set; } // [cite: 106]
        public string Title { get; set; } // [cite: 107]
        public string Description { get; set; } // [cite: 112]
        public string Responsible { get; set; } // [cite: 113]
        public TaskStatus Status { get; set; } // [cite: 113]
        public DateTime CreatedAt { get; set; } // [cite: 113]
        public DateTime? UpdatedAt { get; set; } // [cite: 114]
    }
}