<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="controlEscolar.Frontal.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sistema de Control Escolar</title>
</head>
<body>
    <header>
        <h1>Control escolar</h1>
    </header>
    <section>
        <form id="form1" runat="server">
            <div>
                <asp:Table runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label runat="server">Id del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtID" ToolTip="Ingrese número de boleta"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Label runat="server">Boleta del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtBol" ToolTip="Ingrese número de boleta"></asp:TextBox>
                        </asp:TableCell>
                        
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label runat="server">Nombre del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtNom" ToolTip="Ingrese el nombre del alumno"></asp:TextBox>
                        </asp:TableCell>
                        
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label runat="server">Apellido paterno del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtApa" ToolTip="Ingrese el apellido paterno del alumno"></asp:TextBox>
                        </asp:TableCell>
                        
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label runat="server">Apellido materno del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtAma" ToolTip="Ingrese el apellido materno del alumno"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label runat="server">Sexo del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtSex" ToolTip="Ingrese el sexo del alumno"></asp:TextBox>
                        </asp:TableCell>
                        
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label runat="server">Fecha de nacimiento del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Calendar runat="server" ID="calFNac" ToolTip="Fecha de nacimiento"></asp:Calendar>
                        </asp:TableCell>
                        
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label runat="server">Correo del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtMail" ToolTip="Ingrese el correo del alumno"></asp:TextBox>
                        </asp:TableCell>
                        
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label runat="server">Telefono celular del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtCel" ToolTip="Ingrese el telefono celular del alumno"></asp:TextBox>
                        </asp:TableCell>
                        
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label runat="server">Tipo de sangre del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtSan" ToolTip="Ingrese el tipo de sangre del alumno"></asp:TextBox>
                        </asp:TableCell>
                        
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label runat="server">Carrera del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtCar" ToolTip="Ingrese la clave de carrera del alumno"></asp:TextBox>
                        </asp:TableCell>
                        
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label runat="server">Promedio del alumno: </asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox runat="server" ID="txtProm" ToolTip="Ingrese el promedio del alumno"></asp:TextBox>
                        </asp:TableCell>
                        
                    </asp:TableRow>
                </asp:Table>
                <asp:Button runat="server" ID="btnADD" ToolTip="Agregar alumno" Text="AGREGAR" OnClick="btnADD_Click" />
                <asp:Button runat="server" ID="BtnRegUno" ToolTip="Buscar alumno" Text="BUSCAR" OnClick="BtnRegUno_Click"/>
                <asp:Button runat="server" ID="BtnList" ToolTip="Listar alumnos" Text="LISTAR ALUMNOS" OnClick="BtnList_Click" />
                <asp:Button runat="server" ID="BtnDel" ToolTip="Eliminar un alumno" Text="ELIMNAR" OnClick="BtnDel_Click" />
                <asp:Button runat="server" ID="BtnAct" ToolTip="Actualiza el regisro de un alumno" Text="ACTUALIZAR" OnClick="BtnAct_Click" />
                <asp:Button runat="server" ID="btnXML" ToolTip="Reporte XML" Text="XML" OnClick="btnXML_Click" />
                <asp:Button runat="server" ID="btnGenrarPDF" ToolTip="Reporte PDF" Text="PDF" OnClick="btnGenrarPDF_Click" />
            </div>
        </form>
    </section>
    <div>
        <p>
            <% Response.Write(tablaPres); %>
        </p>
        <asp:DataGrid runat="server" ID="DatosReja" ></asp:DataGrid>
    </div>
</body>
</html>
