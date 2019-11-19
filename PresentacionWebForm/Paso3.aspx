<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paso3.aspx.cs" Inherits="PresentacionWebForm.Paso3" %>

<!DOCTYPE html>
<html lang="es">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <webopt:bundlereference runat="server" path="~/Content/bootstrap.min.css" />
    <webopt:bundlereference runat="server" path="~/Content/Paso3.css" />
    <title>Paso3</title>
</head>
<body>
  <div id="agrupar" runat="server" class="jumbotron text-center">
     <header id="cabecera">
          <h2>Promo Ganá!</h2>
     </header>
     <header id="titulo">
          <h2>Ingresá tus datos</h2>
     </header>
     <form id="form1" runat="server">
        <section id="seccion1">
            <article>
                <asp:Label runat="server" Text="DNI"></asp:Label><br/>
                <asp:TextBox ID="TxtDni" runat="server"></asp:TextBox><br/><br/>
            </article>
        </section>
        <section id="seccion2">
            <article>
                <asp:Label runat="server" Text="Nombre"></asp:Label><br/>
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox><br/><br/>
            </article>
            <article>
                <asp:Label runat="server" Text="Apellido"></asp:Label><br/>
                <asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox><br/><br/>
            </article>
            <article>
                <asp:Label runat="server" Text="Email"></asp:Label><br/>            
                <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox><br/><br/>
            </article>
        </section>
        <section id="seccion3">
            <article>
                <asp:Label runat="server" Text="Direccion"></asp:Label><br/>
                <asp:TextBox ID="TxtDomicilio" runat="server"></asp:TextBox><br/><br/>
            </article>
            <article>
                <asp:Label runat="server" Text="Ciudad"></asp:Label><br/>
                <asp:TextBox ID="TxtCiudad" runat="server"></asp:TextBox><br/><br/>
            </article>
            <article>
                <asp:Label runat="server" Text="CP"></asp:Label><br/>
                <asp:TextBox ID="TxtCp" runat="server"></asp:TextBox><br/><br/>
            </article>
        </section>
        <section id="seccion4">
            <asp:Button ID="participar" runat="server" Text="Participar" CssClass="btn btn-primary btn-lg" 
                OnClick="BtnParticipar_Click" /><br/><br/>
        </section>
     </form>
     <footer id="pie">
         <p>&copy 2019 Programación III</p>
     </footer>
  </div>
  <style>#agrupar{margin-left: 15%;}</style>
</body>
</html>