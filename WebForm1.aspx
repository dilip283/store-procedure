<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Stored_Procedure_Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>Enter Emp No</td>
                <td>
                    <asp:TextBox ID="txtEmpNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Emp Name</td>
                <td>
                    <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Salary</td>
                <td>
                    <asp:TextBox ID="txtEmpSal" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Dept No</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtDeptNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="height: 26px" Text="Delete" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:GridView ID="GridEmp" runat="server">
                    </asp:GridView>
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
