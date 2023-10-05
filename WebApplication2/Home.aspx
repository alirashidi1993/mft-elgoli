<%@ Page Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication2.Home" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="card m-3">
        <div class="card-header">
            ماشین حساب
        </div>
        <div class="card-body">
           <div class="d-flex">
               <label style="min-width:70px;margin-top:auto;margin-bottom:auto;">عدد اول:</label>
               <asp:TextBox CssClass="form-control" ID="txt_adad_aval" runat="server"></asp:TextBox>
           </div>
            <div class="d-flex mt-3">
               <label style="min-width:70px;margin-top:auto;margin-bottom:auto;">عدد دوم:</label>
               <asp:TextBox CssClass="form-control" ID="txt_adad_dovom" runat="server"></asp:TextBox>
           </div>
            <div class="alert alert-success mt-3">
                <asp:Label ID="lbl_hasel" runat="server" Text=""></asp:Label>
            </div>
            <div class="mt-4">
                <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" Text="جمع کن" OnClick="Button1_Click" />
                <asp:Button CssClass="btn btn-warning" ID="Button2" runat="server" Text="تفریق کن" OnClick="Button2_Click" />
                <asp:Button CssClass="btn btn-danger" ID="Button3" runat="server" Text="پاک کردن" OnClick="Button3_Click" />
            </div>
        </div>
    </div>
</asp:Content>


