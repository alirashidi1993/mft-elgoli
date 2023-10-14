<%@ Page Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="CustomerDetails.aspx.cs" Inherits="WebApplication2.CustomerDetails" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="card m-3">
        <div class="card-header">
            جزئیات مشتری
        </div>
        <div class="card-body">
            <table class="table table-bordered table-striped">
                <tr>
                    <th>نام</th>
                    <th>نام خانوادگی</th>
                    <th>کد ملی</th>
                    <th>شماره موبایل</th>
                    <th>آدرس</th>
                    <th>کد پستی</th>
                    <th>تصویر</th>
                    <th>تاریخ تولد</th>
                    <th>نام پدر</th>
                </tr>
                <tr>
                    <td><%=moshtari.FirstName %></td>
                    <td><%=moshtari.LastName %></td>
                    <td><%=moshtari.CodeMelli %></td>
                    <td><%=moshtari.Mobile %></td>
                    <td><%=moshtari.Address %></td>
                    <td><%=moshtari.CodePosti %></td>
                    <td>
                        
                        <img src='Images/<%=moshtari.ImageUrl %>' />
                    </td>
                    <td><%=moshtari.Birthdate.ToString() %></td>
                    <td><%=moshtari.FatherName %></td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>


