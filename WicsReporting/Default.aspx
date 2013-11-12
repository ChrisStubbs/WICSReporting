<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    Inherits="WicsReporting._Default" CodeBehind="Default.aspx.cs" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link href="Styles/tabs.css" rel="stylesheet" type="text/css" />
    <script src="scripts/jquery-1.7.1.min.js" type="text/javascript"></script>
    <script src="scripts/jquery.easytabs.js" type="text/javascript"></script>
    <script src="scripts/jquery.hashchange.min.js" type="text/javascript"></script>
    <script src="scripts/jquery.hashchange.min.js" type="text/javascript"></script>
    <script src="scripts/raphael-min.js" type="text/javascript"></script>
    <script src="scripts/g.raphael-min.js" type="text/javascript"></script>
    <script src="scripts/g.pie-min.js" type="text/javascript"></script>

    <script type="text/javascript" >
        function callMyService(successFunc) {
            $.ajax({
                type: "GET",
                url: "WCF/WicsReports.svc/Summary?m=R1A&tp=AIMERA&fy=2013",
                contentType: "application/json", // content type sent to server
                success: successFunc,
                error: ServiceFailed
            });
        }
       
        // ---- WCF Service call backs -------------------

        function ServiceFailed(result) {
            Log('Service call failed: ' + result.status + '  ' + result.statusText);
        }

    

        // ---- Log ----------------------------------------
        // utility function to output messages

        function Log(msg) {
            $("#logdiv").append(msg + "<br />");
        }

        $(document).ready(function () {
            var loaded = false;
            $('#tab-container').easytabs();
            $('#tab-container')
                .bind('easytabs:before', function (evt, tab, panel, data) {
                    if (!loaded && tab.context.hash === '#tabs1-charges') {
                        callMyService(function (result) {
                            $('#chargesReportData').html(result.SummaryResult);
                            //$('#chargesReportData').css('visibility','hidden');
                        });
                        loaded = true;
                    }
                });

            // Creates in the #chart div
            var r = Raphael('chart');
            // Creates pie chart at with center at 320, 150,

            var pie = r.piechart(320, 150, 100, [55, 20, 13, 32, 5, 1, 2, 10], { legend: ["%%.%% - Enterprise Users", "IE Users"], legendpos: "west", href: ["http://raphaeljs.com", "http://g.raphaeljs.com"] });

            r.text(320, 25, "Interactive Pie Chart").attr({ font: "20px sans-serif" });
            pie.hover(function () {
                this.sector.stop();
                this.sector.scale(1.1, 1.1, this.cx, this.cy);

                if (this.label) {
                    this.label[0].stop();
                    this.label[0].attr({ r: 7.5 });
                    this.label[1].attr({ "font-weight": 800 });
                }
            }, function () {
                this.sector.animate({ transform: 's1 1 ' + this.cx + ' ' + this.cy }, 500, "bounce");

                if (this.label) {
                    this.label[0].animate({ r: 5 }, 500, "bounce");
                    this.label[1].attr({ "font-weight": 400 });
                }
            });

        });
            
    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="content">
        <div id="logdiv">
        </div>
        <div id="tab-container" class="tab-container">
            <ul class='etabs'>
                <li class='tab'><a href="#tabs1-summary">Summary</a></li>
                <li class='tab'><a href="#tabs1-charges">
                    Charges</a></li>
                <li class='tab'><a href="#tabs1-failures">Failures</a></li>
                 <li class='tab'><a href="#tabs1-charts">Charts</a></li>
            </ul>
            <div class='panel-container'>
                <div id="tabs1-summary">
                    <h2>
                        Summary Report</h2>
                    <br />
                    <!-- content -->
                    <div id="summaryReportData" class="reportData">
                     <asp:Literal ID="ltlsummaryReportData" runat="server"></asp:Literal>
                    </div>
                </div>
                <div id="tabs1-charges">
                    <h2>
                        Charges Report Ajax Load</h2>
                    <div id="chargesReportData" class="reportData"></div>
                </div>
                <div id="tabs1-failures">
                    <h2>
                        Failures Report</h2>
                    <p>
                        Proin erat tellus, iaculis non vestibulum a, suscipit a purus. Cras dolor libero,
                        dignissim at neque vel, sollicitudin dignissim sapien. Pellentesque fermentum dapibus
                        arcu, condimentum luctus nulla porttitor eget. Donec eget cursus sapien, id laoreet
                        felis. Donec blandit leo est, eu laoreet dolor placerat quis. Aenean consequat gravida
                        viverra. Nam egestas, ipsum vitae mattis scelerisque, magna metus ultricies ipsum,
                        eu posuere tortor magna non dolor. Proin auctor ornare sollicitudin. Vestibulum
                        ornare eget neque et consectetur. Nullam condimentum metus eu tincidunt consequat.
                        Donec et auctor arcu, in consectetur magna. Praesent ut diam metus. Vivamus eget
                        augue nec magna vehicula tempus. Sed vel risus scelerisque, vulputate felis quis,
                        sagittis mauris. Fusce bibendum posuere diam, non auctor enim lacinia eget. Nullam
                        porttitor suscipit magna.
                    </p>
                </div>
                 <div id="tabs1-charts">
                       <h2>
                       Chart</h2>
                    <div id="chart">
                       
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
