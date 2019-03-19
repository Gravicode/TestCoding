<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="MahasiswaFrm.aspx.cs" Inherits="Soal04.Pages.MahasiswaFrm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageTitle" runat="server">
    Data Mahasiswa
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="table-responsive">
    <asp:GridView ID="Grid1" CssClass="table table-striped" runat="server"></asp:GridView>
    </div>
    
</asp:Content>
