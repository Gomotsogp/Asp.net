<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddSub.aspx.cs" Inherits="WebFormsIdentity.View.AddSub" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="445px" Width="1313px">
        Company :<asp:DropDownList ID="DropDownList1" runat="server" Height="59px" style="margin-left: 115px" Width="349px">
        </asp:DropDownList>
        <br />
        Contact :
        <asp:DropDownList ID="DropDownList2" runat="server" Height="59px" style="margin-left: 126px" Width="348px">
        </asp:DropDownList>
        <br />
        product :
        <asp:DropDownList ID="DropDownList3" runat="server" Height="34px" style="margin-left: 125px" Width="348px">
        </asp:DropDownList>
        <br />
        Number of Users:
        <asp:TextBox ID="TextBox1" runat="server" Height="26px" style="margin-left: 44px" Width="350px"></asp:TextBox>
        <br />
        Subscription start :<asp:TextBox ID="TextBox3" runat="server" Height="28px" style="margin-left: 40px" Width="350px"></asp:TextBox>
        <br />
        Annual :
        <asp:CheckBox ID="CheckBox1" runat="server" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Monthly:
        <asp:CheckBox ID="CheckBox2" runat="server" />
        <br />
        Cost :
        <asp:TextBox ID="TextBox2" runat="server" Height="32px" style="margin-left: 153px" Width="350px"></asp:TextBox>
        <br />
        Sales Rep :
        <asp:DropDownList ID="DropDownList4" runat="server" Height="26px" style="margin-left: 118px" Width="342px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="#3399FF" Height="50px" style="margin-left: 126px" Text="Save" Width="144px" />
    </asp:Panel>
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
