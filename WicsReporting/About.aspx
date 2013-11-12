<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="True"
    CodeBehind="About.aspx.cs" Inherits="WicsReporting.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script type="text/javascript">

        function callMyService() {
            var param = "Hello";
            $.ajax({
                type: "GET",
                url: "WCF/RestServiceImpl.svc/json/123",
                contentType: "application/json", // content type sent to server
                success: ServiceSucceeded,
                error: ServiceFailed
            });
        }
        /*
        function callMyService() {
        var param = "Hello";
        $.ajax({
        type: "POST",
        url: "Default.aspx/GetData",
        data: '{"param": "' + param + '"}',
        contentType: "application/json", // content type sent to server
        success: ServiceSucceeded,
        error: ServiceFailed
        });
        }
        */
        // ---- WCF Service call backs -------------------

        function ServiceFailed(result) {
            Log('Service call failed: ' + result.status + '  ' + result.statusText);
        }

        function ServiceSucceeded(result) {
            Log("Success: " + JSON.stringify(result));
        }

        // ---- Log ----------------------------------------
        // utility function to output messages

        function Log(msg) {
            $("#logdiv").append(msg + "<br />");
        }

        $(document).ready(function () {
            callMyService();
        });
    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="logdiv">
    </div>
    <h2>
        About
    </h2>
    <p>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        Put content here.
    </p>
</asp:Content>
