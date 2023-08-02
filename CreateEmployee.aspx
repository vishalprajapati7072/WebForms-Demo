<%@ Page Title="" Language="C#" MasterPageFile="~/Demo.Master" AutoEventWireup="true" CodeBehind="CreateEmployee.aspx.cs" Inherits="WebApplication3.CreateEmployee" %>

<%@ Register Src="~/CommonTextbox.ascx" TagPrefix="uc1" TagName="CommonTextbox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div style="text-align: center">
        <div style="font-size: medium">
            Create Employee
        </div>
        <uc1:CommonTextbox runat="server" id="CommonTextbox" />
        <uc1:CommonTextbox runat="server" ID="CommonTextbox1" />
        <%--<div>
            <asp:Label ID="Label1" runat="server" Text="FullName">FirstName: </asp:Label>
            <asp:TextBox ID="txt_firstName" runat="server"></asp:TextBox>
        </div>--%>
        <div>
            <asp:Label ID="Label4" runat="server" Text="LastName">LastName: </asp:Label>
            <asp:TextBox ID="txt_lastName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="LastName">Email: </asp:Label>
            <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label7" runat="server" Text="LastName">Gender: </asp:Label>
            <asp:RadioButton ID="rdb_male" runat="server" Text="Male" GroupName="Gender" />
            <asp:RadioButton ID="rdb_female" runat="server" Text="Female" GroupName="Gender" />
            <br />

            <asp:RadioButtonList ID="rdb_lst" runat="server"></asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="FullName">Country: </asp:Label>
            <asp:DropDownList ID="ddl_country" runat="server" CssClass="box-shadow" AutoPostBack="true">
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="LastName">Contact No: </asp:Label>
            <asp:TextBox ID="txt_contactNo" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label8" runat="server" Text="LastName">Salary: </asp:Label>
            <asp:TextBox ID="txt_salary" runat="server"></asp:TextBox>
        </div>
        <hr />

        <div>
            <asp:Button ID="btn_submit" runat="server" Text="Submit" ToolTip="Tooltip" OnClick="btn_submit_Click" />
        </div>
    </div>
</asp:Content>
