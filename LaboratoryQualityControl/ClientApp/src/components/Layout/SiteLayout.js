﻿<!DOCTYPE html>
<html lang="en">
    <head>
		@*<title>@Page.Title</title>*@
        @Html.Partial("_Head.cshtml")
        @RenderSection("Head",required:false)
    </head>
    <body  class="hold-transition sidebar-mini">
        <!-- wrapper -->
        <div class="wrapper">
            <!-- Navbar -->
            @Html.Partial("_Header.cshtml");
            <!-- /.navbar -->

            <!-- Main Sidebar Container -->
            @Html.Partial("_Sidebar.cshtml")
            <!-- /Main Sidebar Container -->

            <!-- Content Wrapper. Contains page content -->
            <div class="content-wrapper">
                    <!-- Content Header (Page header) -->
                    @Html.Partial("_ContentHeader.cshtml")
                    <!-- /.content-header -->

                    <!-- Main content -->
                    <section class="content">
                        <div class="container-fluid">              
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