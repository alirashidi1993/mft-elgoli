<%@ Page Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="WebApplication2.Customers" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <div class="card m-3">
        <div class="card-header">
            مدیریت مشتری ها
        </div>
        <div class="card-body">
            <div class="" style="direction:ltr;">
                <div class="input-group mb-3">
                    <span class="input-group-text" style="padding:0px;" id="basic-addon1">
                        <asp:Button CssClass="btn-search" ID="Button1" runat="server" Text="جستجو" OnClick="Button1_Click" />
                    </span>
                    <asp:TextBox ID="txt_search" CssClass="form-control" style="direction:rtl;" placeholder="جستجو" runat="server"></asp:TextBox>
                    
                </div>
            </div>
            <table class="table table-striped table-bordered">
                <tr>
                    <th>نام</th>
                    <th>نام خانوادگی</th>
                    <th>کد ملی</th>
                    <th>موبایل</th>
                    <th>آدرس</th>
                    <th>ویرایش</th>
                    <th class="text-center">حذف</th>
                </tr>
                <% for (int i = 0; i < moshtariha.Count; i++)
                    { %>
                <tr>
                    <td><%= moshtariha[i].FirstName %></td>
                    <td><%= moshtariha[i].LastName %></td>
                    <td><%= moshtariha[i].CodeMelli %></td>
                    <td><%= moshtariha[i].Mobile %></td>
                    <td><%= moshtariha[i].Address %></td>
                    <td></td>
                    <td class="text-center">
                        <asp:ImageButton  ID="ImageButton1" runat="server" ImageUrl="~/Images/delete.svg" Height="24px" Width="24px" OnCommand="ImageButton1_Command"   />
                    </td>
                </tr>
                <%} %>
            </table>
        </div>
    </div>

</asp:Content>


