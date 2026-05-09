# Arquitectura del Proyecto - TaskFlow

Este documento describe la organización y estructura del sistema de gestión de tareas de **NovaTech Solutions**. El proyecto está desarrollado en C# bajo un enfoque modular para facilitar el mantenimiento y la escalabilidad.

## 📂 Estructura de Carpetas

* **`src/TaskFlow/`**: Carpeta principal que contiene el código fuente del sistema.
    * **`Models/`**: Contiene las clases que definen la estructura de los datos. Ejemplo: `TaskItem.cs`.
    * **`Services/`**: Aquí reside la lógica de negocio y el manejo de datos. Ejemplo: `FileManager.cs`.
    * **`Utils/`**: Clases de apoyo o ayuda para funciones comunes (como formateo de consola).
* **`data/`**: Carpeta destinada al almacenamiento persistente. Aquí se genera el archivo `tasks.json`.
* **`docs/`**: Espacio dedicado a la documentación técnica y manuales de usuario.
* **`tests/`**: Contiene los proyectos de pruebas unitarias para asegurar que el código funcione correctamente.

## ⚙️ Flujo de Funcionamiento

1. El usuario interactúa con la interfaz de consola en `Program.cs`.
2. Las peticiones son procesadas por los **Services**.
3. Los datos se moldean utilizando los **Models**.
4. La información se guarda y recupera del archivo JSON en la carpeta **data** mediante el `FileManager`.