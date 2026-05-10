public void UpdateTaskStatus(int id, TaskStatus newStatus)
{
    var task = _tasks.FirstOrDefault(t => t.Id == id);

    if (task != null)
    {
        task.Status = newStatus; // Cambiamos el estado
        task.UpdatedAt = DateTime.Now; // Registramos cuándo se cambió
        Console.WriteLine($"[INFO] Tarea {id} actualizada a {newStatus}");
    }
    else
    {
        Console.WriteLine("[ERROR] No se encontró la tarea con ese ID.");
    }
}
.