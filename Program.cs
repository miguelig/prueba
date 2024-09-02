using prueba;

class Program
{
    static List<Tarea> tareas = new List<Tarea>();

    static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n--- Menú de Tareas ---");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Eliminar tarea");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarTarea();
                    break;
                case "2":
                    ListarTareas();
                    break;
                case "3":
                    MarcarTareaComoCompletada();
                    break;
                case "4":
                    EliminarTarea();
                    break;
                case "5":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }
        }
    }

    static void AgregarTarea()
    {
        Console.Write("Descripción de la tarea: ");
        string descripcion = Console.ReadLine();

        Console.Write("Fecha límite (dd/MM/yyyy) (opcional): ");
        DateTime? fechaLimite = null;
        string fechaInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(fechaInput))
        {
            if (DateTime.TryParse(fechaInput, out DateTime fecha))
            {
                fechaLimite = fecha;
            }
            else
            {
                Console.WriteLine("Fecha no válida. Se omitirá la fecha límite.");
            }
        }

        Tarea nuevaTarea = new Tarea(tareas.Count + 1, descripcion, fechaLimite);
        tareas.Add(nuevaTarea);
        Console.WriteLine("Tarea agregada exitosamente.");
    }

    static void ListarTareas()
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas registradas.");
        }
        else
        {
            foreach (var tarea in tareas)
            {
                Console.WriteLine($"[{tarea.Id}] {tarea.Descripcion} - {(tarea.Completada ? "Completada" : "Pendiente")}" +
                                  $"{(tarea.FechaLimite.HasValue ? $" (Fecha límite: {tarea.FechaLimite.Value.ToShortDateString()})" : "")}");
            }
        }
    }

    static void MarcarTareaComoCompletada()
    {
        Console.Write("ID de la tarea a marcar como completada: ");
        if (int.TryParse(Console.ReadLine(), out int idTarea))
        {
            Tarea tarea = tareas.FirstOrDefault(t => t.Id == idTarea);
            if (tarea != null)
            {
                tarea.Completada = true;
                Console.WriteLine("Tarea marcada como completada.");
            }
            else
            {
                Console.WriteLine("Tarea no encontrada.");
            }
        }
        else
        {
            Console.WriteLine("ID no válido.");
        }
    }

    static void EliminarTarea()
    {
        Console.Write("ID de la tarea a eliminar: ");
        if (int.TryParse(Console.ReadLine(), out int idEliminar))
        {
            Tarea tarea = tareas.FirstOrDefault(t => t.Id == idEliminar);
            if (tarea != null)
            {
                tareas.Remove(tarea);
                Console.WriteLine("Tarea eliminada.");
            }
            else
            {
                Console.WriteLine("Tarea no encontrada.");
            }
        }
        else
        {
            Console.WriteLine("ID no válido.");
        }
    }
}