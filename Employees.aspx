<%@ Page Title="" Language="C#" MasterPageFile="~/Demo.Master" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="WebApplication3.Employees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <asp:GridView ID="grid_emp" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-BackColor="Green" />
            <asp:BoundField HeaderText="FirstName" DataField="FirstName" ControlStyle-BackColor="Red" ControlStyle-Font-Bold="true" />
            <asp:BoundField HeaderText="LastName" DataField="LastName" ControlStyle-BackColor="PowderBlue" ControlStyle-Font-Bold="true" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:TextBox ID="txt_Email" runat="server" Text='<%# Eval("Email") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Country Name" DataField="CountryName" ControlStyle-BackColor="PowderBlue" ControlStyle-Font-Bold="true" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnk_edit" runat="server" CommandArgument='<%#Eval("Id")%>' OnCommand="lnk_edit_Click">Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnk_delete" runat="server" CommandArgument='<%#Eval("Id")%>' OnCommand="lnk_delete_Command">Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
