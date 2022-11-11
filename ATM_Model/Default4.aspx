<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default4.aspx.cs" Inherits="ATM_Model.Default4" %>

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
                    width: 29%;
                    height: 135px;
                }

                .ttt {
                    opacity: 1;
                }

                .auto-style2 {
                    width: 720px;
                    height: 79px;
                }

                </style>
            <div class="home">
                <h1>Welcome to SBI.NET ATM</h1>
                <h2>Banking Services 24x7</h2>
                <table align="center" class="auto-style1">
                    <tr>
                        <td>
                            <br />
                            <h1 class="auto-style2">Thank You For Using The Service...❤</h1>
                            <p class="auto-style2">
                                <asp:Button ID="Button1" runat="server" BackColor="#6600CC" ForeColor="White" Height="49px" OnClick="Button1_Click" Text="Back to Login" Width="201px" />
                            </p></td>
                    </tr>
                    </table>

            </div>
        </div>
    </form>

</body>
</html>
