<%@ Page Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="WebApplication2.Customers" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

   <div class="card m-3">
  <div class="card-header">
    مدیریت مشتری ها
  </div>
  <div class="card-body">
    <table class="table table-striped table-bordered">
        <tr>
            <th>نام</th>
            <th>نام خانوادگی</th>
            <th>کد ملی</th>
            <th>موبایل</th>
            <th>آدرس</th>
            <th></th>
            <th></th>
        </tr>
        <% foreach (var customer in moshtariha) { %>
        <tr>
            <td><%= customer.FirstName %></td>
            <td><%= customer.LastName %></td>
            <td><%= customer.CodeMelli %></td>
            <td><%= customer.Mobile %></td>
            <td><%= customer.Address %></td>
            <td></td>
            <td></td>
        </tr>
        <%} %>
    </table>
  </div>
</div>

</asp:Content>


