import React, { Component } from 'react';
import { NavLink } from 'react-router-dom'
export default class ContentHeader extends Component {
    //static displayName = Sidebar.name;

    render() {
        return (
            <div className="content-header">
                <div className="container-fluid">
                    <div className="row mb-2">
                        <div className="col-sm-6">
                            <h1 className="m-0 text-dark">داشبورد</h1>
                        </div>{/* /.col */}
                        <div className="col-sm-6">
                            <ol className="breadcrumb float-sm-left">
                                <li className="breadcrumb-item"><NavLink to="/">خانه</NavLink></li>
                                <li className="breadcrumb-item active">داشبورد ورژن 2</li>
                            </ol>
                        </div>{/* /.col */}
                    </div>{/* /.row */}
                </div>{/* /.container-fluid */}
            </div>
        );
    }
}