<!DOCTYPE html>
<html lang="en">
    <head>
		@*<title>@Page.Title</title>*@
        @Html.Partial("_Head.cshtml")
        @RenderSection("Head",required:false)
    </head>
    <body  className="hold-transition sidebar-mini">
        <!-- wrapper -->
        <div className="wrapper">
            <!-- Navbar -->
            @Html.Partial("_Header.cshtml");
            <!-- /.navbar -->

            <!-- Main Sidebar Container -->
            @Html.Partial("_Sidebar.cshtml")
            <!-- /Main Sidebar Container -->

            <!-- Content Wrapper. Contains page content -->
            <div className="content-wrapper">
                    <!-- Content Header (Page header) -->
                    @Html.Partial("_ContentHeader.cshtml")
                    <!-- /.content-header -->

                    <!-- Main content -->
                    <section className="content">
                        <div className="container-fluid">              
                            @RenderBody();
                        </div><!-- /.container-fluid -->
                    </section>                    
                    <!-- /Main content -->
            </div>
            <!-- /.content-wrapper -->              

            <!-- footer -->
            @Html.Partial("_Footer.cshtml")
            <!-- /footer -->

              <!-- Control Sidebar -->
                @Html.Partial("_ControlSidebar.cshtml")
              <!-- /.control-sidebar -->
        </div>
        <!-- ./wrapper -->

        <!-- Footer Scripts -->
        @Html.Partial("_FooterScripts.cshtml")
        @RenderSection("Scripts",required:false)
        <!-- /Footer Scripts -->
    </body>
</html>