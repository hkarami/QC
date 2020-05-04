import React, { Component } from 'react';
import Sidebar from './Sidebar'
import Header from './Header'
import ContentHeader from './ContentHeader'
import Footer from './Footer'
import ControlSidebar from './ControlSidebar'
export class Layout extends Component {
    static displayName = Layout.name;

    render() {
        return (

            <React.Fragment>
                {/* wrapper 
                <div className="wrapper">*/}
                {/* Navbar */}
                <Header />
                {/* /.navbar */}

                {/* Main Sidebar Container */}
                <Sidebar />
                {/* /Main Sidebar Container */}

                {/* Content Wrapper. Contains page content */}
                <div className="content-wrapper">
                    {/* Content Header (Page header) */}
                    <ContentHeader />
                    {/* /.content-header */}

                    {/* Main content */}
                    <section className="content">
                        <div className="container-fluid">
                            {this.props.children}
                        </div>{/* /.container-fluid */}
                    </section>
                    {/* /Main content */}
                </div>
                {/* /.content-wrapper */}

                {/* footer */}
                <Footer />
                {/* /footer */}

                {/* Control Sidebar */}
                <ControlSidebar />
                {/* /.control-sidebar */}
                {/* </div>
               ./wrapper */}

                {/* Footer Scripts */}
                {/*@Html.Partial("_FooterScripts.cshtml")*/}
                {/*@RenderSection("Scripts",required:false)*/}
                {/* /Footer Scripts */}

            </React.Fragment>
        );
    }
}

export default Layout;