<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ATM_Model.Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <style>
                body {
                    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                    background-image: url(atm1.jpg);
                    background-size: cover;
                }

                .home {
                    background-color: white;
                    opacity: 0.8;
                    margin-top: 8%;
                    font-size: larger;
                    text-align: center;
                    overflow: hidden;
                    width: auto;
                }

                .auto-style1 {
                    width: 50%;
                }

                .auto-style4 {
                    height: 60px;
                }

                .auto-style5 {
                    height: 60px;
                    width: 346px;
                }

                .auto-style6 {
                    margin-left: 0px;
                }

                .auto-style7 {
                    height: 72px;
                }

                .ttt {
                    opacity: 1;
                }

                .auto-style8 {
                    height: 50px;
                }
            </style>
            <div class="home">
                <h1>Welcome to SBI.NET ATM</h1>
                <h2>Banking Services 24x7</h2>
                <table align="center" class="auto-style1">
                    <tr>
                        <td class="auto-style5">Enter the new PIN</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style6" TextMode="Password" Height="32px" Width="218px" MaxLength="4"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7" colspan="2">
                            <asp:Button ID="Button1" runat="server" BackColor="#6600FF" ForeColor="White" Height="51px" CssClass="ttt" Text="Set PIN" Width="167px" OnClick="Button1_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style8" colspan="2">
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                            <br />
                        </td>
                    </tr>
                </table>

            </div>
        </div>
    </form>

</body>
</html>
