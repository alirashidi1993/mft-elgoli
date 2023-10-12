<%@ Page Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="WebApplication2.Customers" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <div class="card m-3">
        <div class="card-header">
            مدیریت مشتری ها
        </div>
        <div class="card-body">
            <div class="card">
                <div class="card-header">
                    افزودن مشتری جدید
                </div>
                <div class="card-body">
                    <div class="row">
                        <div class="col-md-6">
                            <label class="mb-1 fw-bold">نام:</label>
                            <asp:TextBox CssClass="form-control" ID="txt_firstname" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <label class="mb-1 fw-bold">نام خانوادگی:</label>
                            <asp:TextBox CssClass="form-control" ID="txt_lastname" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row mt-3">
                        <div class="col-md-6">
                            <label class="mb-1 fw-bold">کد ملی:</label>
                            <asp:TextBox CssClass="form-control" ID="txt_codemelli" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <label class="mb-1 fw-bold">شماره موبایل:</label>
                            <asp:TextBox CssClass="form-control" ID="txt_mobile" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row mt-3">
                        <div class="col-md-12">
                            <label class="mb-1 fw-bold">آدرس:</label>
                            <asp:TextBox CssClass="form-control" ID="txt_address" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="mt-4">
                        <asp:Button ID="Button2" runat="server" Text="افزودن" CssClass="btn btn-success" OnClick="Button2_Click" />
                    </div>
                </div>
            </div>

            <div class="mt-3" style="direction: ltr;">
                <div class="input-group mb-3">
                    <span class="input-group-text" style="padding: 0px;" id="basic-addon1">
                        <asp:Button CssClass="btn-search" ID="Button1" runat="server" Text="جستجو" OnClick="Button1_Click" />
                    </span>
                    <asp:TextBox ID="txt_search" CssClass="form-control" Style="direction: rtl;" placeholder="جستجو" runat="server"></asp:TextBox>

                </div>
            </div>
            <div>
                <asp:GridView ID="GridView1" CssClass="table table-striped table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="FirstName" HeaderText="نام" />
                        <asp:BoundField DataField="LastName" HeaderText="نام خانوادگی" />
                        <asp:BoundField DataField="CodeMelli" HeaderText="کد ملی" />
                        <asp:BoundField DataField="Mobile" HeaderText="شماره موبایل" />
                        <asp:BoundField DataField="Address" HeaderText="آدرس" />
                        <asp:BoundField DataField="Id" Visible="False" />
                        <asp:CommandField ButtonType="Image" DeleteImageUrl="~/Images/delete.png" DeleteText="" ShowDeleteButton="True">
                            <ControlStyle Height="24px" Width="24px" />
                        </asp:CommandField>
                    </Columns>
                </asp:GridView>
            </div>

        </div>
    </div>

</asp:Content>


