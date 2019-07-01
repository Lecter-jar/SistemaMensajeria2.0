<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MiLogin.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html lang="en">
<head>
	<title>Login</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">	

	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
	<link rel="stylesheet" type="text/css" href="fonts/Linearicons-Free-v1.0.0/icon-font.min.css">
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
<!--===============================================================================================-->
</head>
<body>
    <div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100 p-l-85 p-r-85 p-t-55 p-b-55">
    <form class="login100-form validate-form flex-sb flex-w" runat="server">
					<span class="login100-form-title p-b-32">
						Acceso Sistema Mensajeria
					</span>
        <span class="txt1 p-b-11">
						Username
		</span>
        <div class="wrap-input100 validate-input m-b-36" data-validate = "Username is required">
						 <asp:TextBox ID="txtUsuario" placeholder="Usuario" runat="server" CssClass="input100"></asp:TextBox>
						<span class="focus-input100"></span>
		</div>
        <span class="txt1 p-b-11">
						Password
		</span>

        <div class="wrap-input100 validate-input m-b-12" data-validate = "Password is required">
						<span class="btn-show-pass">
							<i class="fa fa-eye"></i>
						</span>
						<asp:TextBox ID="txtClave" type="password" placeholder="Contraseña" runat="server" CssClass="input100" TextMode="Password"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

        <div class="container-login100-form-btn">
            <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" CssClass="login100-form-btn" />
					</div>

				<asp:Label ID="lblMensaje" runat="server" Text="" Visible="False"></asp:Label>

           
   
    </form>
                </div>
		</div>
	</div>

    <!--===============================================================================================-->
	<script src="js/main.js"></script>
</body>
</html>





