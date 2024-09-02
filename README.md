# prueba
Clase Tarea La clase Tarea se define como un record, una nueva característica de C# que representa datos inmutables. Este record incluye cuatro propiedades:
Id: Un identificador único para cada tarea.
Descripcion: Una descripción de la tarea.
FechaLimite: Una fecha límite opcional para completar la tarea.
Completada: Un booleano que indica si la tarea ha sido completada.
El uso de records permite manejar objetos de manera eficiente, aprovechando la inmutabilidad y proporcionando una sintaxis simple para copiar y modificar instancias usando la expresión with.

Lógica del Menú El programa presenta un menú interactivo en la consola, donde el usuario puede seleccionar diferentes opciones para gestionar las tareas. El menú se implementa con un bucle while que sigue activo hasta que el usuario decide salir. La entrada del usuario se maneja con una expresión switch, que ejecuta la función correspondiente según la opción seleccionada.
Funciones del Menú Cada opción del menú se implementa en un método separado, mejorando la legibilidad y mantenibilidad del código.
AgregarTarea: Este método permite al usuario ingresar la descripción de una tarea y opcionalmente una fecha límite. Si se ingresa una fecha inválida, el programa omite la fecha límite. La nueva tarea se agrega a la lista de tareas usando el método Add de List<T>.
ListarTareas: Este método muestra todas las tareas almacenadas en la lista. Para cada tarea, se muestra su descripción, estado (completada o pendiente), y la fecha límite, si está disponible. Si no hay tareas registradas, se muestra un mensaje adecuado.
MarcarTareaComoCompletada: Este método permite al usuario marcar una tarea como completada a través de su ID. Utiliza la funcionalidad with de los records para crear una nueva instancia de la tarea marcada como completada sin modificar la instancia original.
EliminarTarea: Permite al usuario eliminar una tarea de la lista, identificándola por su ID.
Manejo de Nullables y Validación Las entradas del usuario se manejan de manera robusta mediante el uso de tipos anulables (?) y validaciones con TryParse. Esto garantiza que el programa no falle ante entradas inválidas y proporcione mensajes informativos al usuario.
