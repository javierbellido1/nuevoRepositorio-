using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TaskFlow.Models;

namespace TaskFlow.Services
{
    public static class FileManager
    {
        [cite_start]// Ruta donde se guardará el JSON según el PDF [cite: 101]
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "tasks.json");

        public static void SaveTasks(List<TaskItem> tasks)
        {
            try 
            {
                [cite_start]// Crea la carpeta data si no existe [cite: 102, 124]
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

                string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
                [cite_start]File.WriteAllText(filePath, json); [cite: 123]
            }
            catch (Exception ex) 
            {
                [cite_start]Console.WriteLine($"Error al guardar: {ex.Message}"); [cite: 125]
            }
        }

        public static List<TaskItem> LoadTasks()
        {
            [cite_start]if (!File.Exists(filePath)) return new List<TaskItem>(); [cite: 124]
            
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<TaskItem>>(json);
        }
    }
}