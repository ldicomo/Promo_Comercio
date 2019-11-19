<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paso2.aspx.cs" Inherits="PresentacionWebForm.Paso2" %>

<!DOCTYPE html>
<html lang="es">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <webopt:bundlereference runat="server" path="~/Content/bootstrap.min.css" />
    <title>Paso1</title>
</head>
<body>
  <div id="agrupar" runat="server" class="jumbotron text-center">
     <header id="cabecera">
          <h1>Promo Ganá!</h1>
     </header>
     <header id="titulo">
          <h1>Elegí tu premio</h1>
     </header>
     <section id="seccion">
       <form id="opciones" runat="server">
         <article>
              <figure>
                 <img src="Mochila Notebook.jpg">
                 <figcaption>
                     Mochila Notebook
                 </figcaption>
             </figure>
             <br><h5>La mejor mochila que vas a tener</h5><br/>
             <asp:Button ID="BtnEnviar1" runat="server" Text="Quiero este!" CssClass="btn btn-primary btn-lg" 
                 OnClick="BtnEnviar1_Click" />
         </article>
         <article>
             <figure>
                 <img src="Auriculares Gamer.jpg">
                 <figcaption>
                     Auriculares Gamer
                 </figcaption>
             </figure>
             <br><h5>Escuchá los pasos del enemigo</h5><br/>
             <asp:Button ID="BtnEnviar2" runat="server" Text="No, mejor este" CssClass="btn btn-primary btn-lg" 
                 OnClick="BtnEnviar2_Click" />
         </article>
         <article>
             <figure>
                 <img src="Mouse Gamer.jpg">
                 <figcaption>
                     Mouse Gamer
                 </figcaption>
             </figure>
             <br><h5>Presición es mi segundo nombre</h5><br/>
             <asp:Button ID="BtnEnviar3" runat="server" Text="Mejor este" CssClass="btn btn-primary btn-lg" 
                 OnClick="BtnEnviar3_Click" />
         </article>
       </form>
     </section>
     <footer id="pie">
         <p>&copy 2019 Programación III</p>
     </footer>
  </div>
     <webopt:bundlereference runat="server" path="~/Content/Paso2.css" />
</body>
</html>