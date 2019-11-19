<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paso1.aspx.cs" Inherits="PresentacionWebForm.Paso1" %>

<!DOCTYPE html>
<html lang="es">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <webopt:bundlereference runat="server" path="~/Content/bootstrap.min.css" />
    <webopt:bundlereference runat="server" path="~/Content/Paso1.css" />
    <title>Paso1</title>
</head>
<body>
  <div id="agrupar" runat="server" class="jumbotron text-center">
     <header id="cabecera">
          <h1>Promo Ganá!</h1>
     </header>
     <section id="seccion">  
         <form id="form1" runat="server">
             <br/><br/>
             <p>Ingresá el código de tu voucher<br></p>
             <asp:textbox placeholder="Código de 4 dígitos" ID="TxtVoucher" runat="server"></asp:textbox>
             <br/><br/>
             <asp:Button ID="BtnEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary btn-lg" OnClick="BtnSiguiente_Click" />
             <br/>
         </form>
     </section>
     <footer id="pie">
         <hr/><br/>
         <p>&copy 2019 Programación III</p>
     </footer>
  </div>
  <style>
      #seccion {background: #AAAAAA;}
      #form1 {margin-left: 28%;}
  </style>
</body>
</html>
