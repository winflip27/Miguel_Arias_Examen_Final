<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Miguel_Arias_Examen_Final.Vistas.Login" %>

<!DOCTYPE html>

<html lang="es">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewBag.Title</title>
    <link rel="stylesheet" href="~/Content/styles.css" />
</head>
<body>
    <div class="login-container">
        <h2>Iniciar Sesión</h2>
        @using (Html.BeginForm("Login", "Account", FormMethod.Post))
        {
            @Html.AntiForgeryToken()
            <div class="form-group">
                @Html.LabelFor(m => m.Email)
                @Html.TextBoxFor(m => m.Email, new { @class = "form-control" })
                @Html.ValidationMessageFor(m => m.Email)
            </div>
            <div class="form-group">
                @Html.LabelFor(m => m.Contraseña)
                @Html.PasswordFor(m => m.Contraseña, new { @class = "form-control" })
                @Html.ValidationMessageFor(m => m.Contraseña)
            </div>
            <button type="submit" class="btn-submit">Iniciar Sesión</button>
        }
    </div>
</body>
</html>