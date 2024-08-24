<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Miguel_Arias_Examen_Final.Vistas.Menu" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewBag.Title - Mi Aplicación</title>
    <link rel="stylesheet" href="~/Content/styles.css" />
</head>
<body>
    <header>
        <nav class="navbar">
            <div class="container">
                <a href="/" class="navbar-brand">Mi Aplicación</a>
                <ul class="navbar-menu">
                    <li><a href="/">Inicio</a></li>
                    <li><a href="/Viajeros">Viajeros</a></li>
                    <li><a href="/EntradasSalidas">Entradas y Salidas</a></li>
                    <li><a href="/Visas">Visas</a></li>
                    <li><a href="/Account/Login">Iniciar Sesión</a></li>
                </ul>
            </div>
        </nav>
    </header>

    <main>
        @RenderBody()
    </main>

    <footer>
        <div class="container">
            <p>&copy; 2024 Mi Aplicación. Ningun derecho ni izquierdo reservado.</p>
        </div>
    </footer>
</body>
</html>
