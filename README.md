📺 Catálogo de Animes ASP.NET Core MVC

Aplicación web desarrollada con ASP.NET Core MVC que permite visualizar un catálogo de animes y realizar cotizaciones de animes seleccionados, calculando el precio según el tipo de anime y la cantidad solicitada.

Este proyecto fue desarrollado como práctica del patrón Modelo - Vista - Controlador (MVC) utilizando C#, Razor, HTML y CSS.

🚀 Tecnologías utilizadas
ASP.NET Core MVC
C#
Razor Views
HTML5
CSS3
Visual Studio
🏗 Arquitectura del proyecto

El proyecto sigue el patrón MVC (Model - View - Controller):

📦 Models

Contiene las clases que representan los datos del sistema.

Ejemplo:

ClassCotizar

Este modelo contiene propiedades como:

Cliente
Empresa
Cantidad
Tipo de Anime
Precio
Total
🎮 Controllers

Se encargan de manejar las solicitudes del usuario.

Ejemplo:

AnimeController

Acciones principales:

Cotizar() → muestra el formulario de cotización
CalculoCotizar() → procesa la cotización y calcula el total

El cálculo del precio se realiza mediante un algoritmo usando switch que asigna el precio dependiendo del anime seleccionado.

🖥 Views

Las vistas están desarrolladas usando Razor (.cshtml).

Principales vistas:

Cotizar.cshtml → formulario para ingresar datos de cotización
CalculoCotizar.cshtml → muestra el resultado de la cotización
LayoutMaster.cshtml → plantilla principal del sitio
📚 Funcionalidades

✔ Catálogo de animes
✔ Selección de anime mediante lista desplegable
✔ Formulario de cotización
✔ Cálculo automático del precio
✔ Multiplicación del precio por la cantidad
✔ Vista de resumen de cotización
✔ Diseño con HTML y CSS

🧮 Lógica de cotización

El sistema calcula el precio dependiendo del anime seleccionado.

Ejemplo conceptual:

switch(animeSeleccionado)
{
    case "Dragon01":
        precio = 50;
        break;

    case "Naruto01":
        precio = 40;
        break;
}

Luego se calcula el total:

Total = Precio * Cantidad;
📂 Estructura del proyecto
Ejercicio01
│
├── Controllers
│     └── AnimeController.cs
│
├── Models
│     └── ClassCotizar.cs
│
├── Views
│     ├── Anime
│     │     ├── Cotizar.cshtml
│     │     └── CalculoCotizar.cshtml
│     │
│     └── Shared
│           └── _LayoutMaster.cshtml
│
├── wwwroot
│     └── css
│
└── Program.cs
⚙️ Cómo ejecutar el proyecto

1️⃣ Clonar el repositorio

git clone https://github.com/EDU11QR/Ejecicio01-DSW.git

2️⃣ Abrir el proyecto en Visual Studio

3️⃣ Restaurar paquetes de NuGet si es necesario.

4️⃣ Ejecutar el proyecto con:

Ctrl + F5
📸 Ejemplo del sistema
Formulario de Cotización

El usuario ingresa:

Cliente
Empresa
Cantidad
Anime seleccionado

Luego presiona Cotizar.

Resultado de Cotización

El sistema muestra:

Cliente
Empresa
Tipo de Anime
Precio unitario
Cantidad
Total calculado
📌 Posibles mejoras futuras
Agregar base de datos con SQL Server
Guardar historial de cotizaciones
Crear listado de cotizaciones
Agregar validaciones del formulario
Mejorar diseño responsive
Agregar autenticación de usuarios
👨‍💻 Autor

Edu Quispe Rojas

Proyecto desarrollado como práctica de ASP.NET Core MVC para reforzar el uso del patrón MVC y la lógica de negocio en C#.
