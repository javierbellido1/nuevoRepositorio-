using System;
using TaskFlow.Models;
using TaskFlow.Services;

namespace TaskFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskService service = new TaskService();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- SISTEMA TASKFLOW: NOVATECH ---");
                Console.WriteLine("1. Crear Tarea");
                Console.WriteLine("2. Listar Tareas");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                if (opcion == "1") {
                    Console.Write("Título: "); string t = Console.ReadLine();
                    Console.Write("Responsable: "); string r = Console.ReadLine();
                    service.CreateTask(t, "Sin descripción", r);
                }
                else if (opcion == "2") {
                    Console.WriteLine("\n--- LISTA DE TAREAS ACTUALES ---");
                    foreach (var task in service.GetAllTasks()) {
                        Console.WriteLine($"ID: {task.Id} | {task.Title} | Responsable: {task.Responsible} | Estado: {task.Status}");
                    }
                }
                else if (opcion == "6") {
                    salir = true;
                }
                else if (opcion == "3")
                {
                    Console.Write("Ingrese el ID de la tarea a actualizar: ");
                    int id = int.Parse(Console.ReadLine()); // Convertimos el texto en número

                    Console.WriteLine("Elija el nuevo estado: (0: Pendiente, 1: En Progreso, 2: Completada)");
                    int nuevoEstadoNum = int.Parse(Console.ReadLine());

                    // Convertimos el número al Enum de TaskStatus
                    TaskStatus nuevoEstado = (TaskStatus)nuevoEstadoNum;

                    // --- LLAMÁ AL MÉTODO DEL SERVICE ACÁ ---
                    // pista: service.UpdateTaskStatus(id, nuevoEstado);
                }
            }
        }
    }
}