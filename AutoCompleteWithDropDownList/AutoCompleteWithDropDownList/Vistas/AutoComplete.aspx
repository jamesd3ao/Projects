<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AutoComplete.aspx.cs" Inherits="AutoCompleteWithDropDownList.Vistas.AutoComplete" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../Scripts/jquery-1.11.1.js"></script>
    <script src="../Scripts/jquery-ui-1.11.4.js"></script>
    <script src="../Scripts/chosen.jquery.js"></script>
    <link href="../Content/chosen.css" rel="stylesheet" />

    <script type="text/javascript">
    
    </script>

    <div id="form">
        <h1>AutoComplete With DropDownList</h1>

        <section>
            <article>
                <h2>The controls asp don't working with the control ajaxcontroltoolkit AutoCompleteExtender.</h2>
                <%--<ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="ddlAutoComplete"></ajaxToolkit:AutoCompleteExtender>--%>

                <h2>AutoComplete using the library Chosen.Jquery</h2>
                <asp:DropDownList ID="DDL_Groups4_Assign" runat="server" data-placeholder="Choose a Country..." CssClass="chzn-select" AppendDataBoundItems="True" AutoPostBack="True" CausesValidation="True" Width="250px">
                    <asp:ListItem Value="1">Puerto Libertador</asp:ListItem>
                    <asp:ListItem Value="2">Montelíbano</asp:ListItem>
                    <asp:ListItem Value="3">Uré</asp:ListItem>
                    <asp:ListItem>Caucasia</asp:ListItem>
                    <asp:ListItem>Sahagún</asp:ListItem>
                    <asp:ListItem>Puerto Libertador</asp:ListItem>
                    <asp:ListItem>Montelíbano</asp:ListItem>
                    <asp:ListItem>Uré</asp:ListItem>
                    <asp:ListItem>Caucasia</asp:ListItem>
                    <asp:ListItem>Sahagún</asp:ListItem>
                    <asp:ListItem>Puerto Libertador</asp:ListItem>
                    <asp:ListItem>Montelíbano</asp:ListItem>
                    <asp:ListItem>Uré</asp:ListItem>
                    <asp:ListItem>Caucasia</asp:ListItem>
                    <asp:ListItem>Sahagún</asp:ListItem>
                    <asp:ListItem>Puerto Libertador</asp:ListItem>
                    <asp:ListItem>Montelíbano</asp:ListItem>
                    <asp:ListItem>Uré</asp:ListItem>
                    <asp:ListItem>Caucasia</asp:ListItem>
                    <asp:ListItem>Sahagún</asp:ListItem>
                </asp:DropDownList>

            </article>
            <article>
                <br />
                <a>References: https://harvesthq.github.io/chosen/
                </a>
            </article>
        </section>
        <footer></footer>
    </div>
    <script type="text/javascript"> $(".chzn-select").chosen(); $(".chzn-select-deselect").chosen({ allow_single_deselect: true }); </script>
</asp:Content>
