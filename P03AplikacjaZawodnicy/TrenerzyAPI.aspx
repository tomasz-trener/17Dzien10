<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrenerzyAPI.aspx.cs" Inherits="P03AplikacjaZawodnicy.TrenerzyAPI" %>


<div class="card">
    <div class="card-header">
        <h5 class="title">Edit Profile</h5>
    </div>
    <div class="card-body">
        <form runat="server">
            <div class="row">
                <div class="col-md-5 px-1">
                    <div class="form-group">
                        <label>Imie</label>
                        <asp:TextBox ID="txtImie" CssClass="form-control" runat="server"></asp:TextBox>
                        <%-- <input type="text" class="form-control" value="<%= Zaznaczony.Imie %>">--%>
                    </div>
                </div>
                <div class="col-md-5 pl-1">
                    <div class="form-group">
                        <label>Nazwisko</label>
                        <asp:TextBox ID="txtNazwisko" CssClass="form-control" runat="server"></asp:TextBox>
                        <%--<input type="text" class="form-control" value="<%= Zaznaczony.Nazwisko %>">--%>
                    </div>
                </div>
            </div>

        </form>
    </div>
</div>

