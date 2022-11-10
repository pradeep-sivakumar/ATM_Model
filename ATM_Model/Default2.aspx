<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="ATM_Model.Default2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .btn{
            border-radius:4px;
            border : 1px solid white;
        }
        .auto-style1 {
            margin-top:10%;
            width: 50%;
            background-color:white;
            border-radius:10px;
        height: 333px;
        margin-bottom: 18px;
    }
    .auto-style3 {
        width: 356px;
        height: 61px;
    }
    .auto-style4 {
        height: 61px;
    }
    .auto-style5 {
        width: 356px;
        height: 50px;
    }
    .auto-style8 {
        width: 356px;
        height: 31px;
    }
    .auto-style9 {
        height: 31px;
    }
    .auto-style10 {
        height: 70px;
    }
    .auto-style11 {
        height: 55px;
    }
        .auto-style12 {
            height: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center">

        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style8">
                </td>
                <td class="auto-style9">
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Enter the amount to withdraw"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" Height="32px" Width="260px" MaxLength="5"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Text="Enter your PIN"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="TextBox2" runat="server" Height="32px"  Width="260px" TextMode="Password" MaxLength="4" ToolTip="PIN"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10" colspan="2">
                    <asp:Button ID="Button1" runat="server" BackColor="#6600FF" ForeColor="White" Height="51px" Text="Withdraw" Width="185px" CssClass="btn" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style11" colspan="2">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
