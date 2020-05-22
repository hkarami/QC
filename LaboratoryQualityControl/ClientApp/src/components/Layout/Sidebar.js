﻿import React, { Component } from 'react';
import { NavLink } from 'react-router-dom'

export class Sidebar extends Component {
    //static displayName = Sidebar.name;

    render() {
        return (
            <aside className="main-sidebar sidebar-dark-primary elevation-4">
                {/* Brand Logo */}
                <a href="index3.html" className="brand-link">
                    <img src="/content/img/AdminLTELogo.png" alt="AdminLTE Logo" className="brand-image img-circle elevation-3"
                        style={{ opacity: .8 }} />
                    <span className="brand-text font-weight-light">پنل مدیریت</span>
                </a>

                {/* Sidebar */}
                <div className="sidebar" style={{ direction: "ltr" }}>
                    <div style={{ direction: "rtl" }}>
                        {/* Sidebar user panel (optional) */}
                        <div className="user-panel mt-3 pb-3 mb-3 d-flex">
                            <div className="image">
                                <img src="https://www.gravatar.com/avatar/52f0fbcbedee04a121cba8dad1174462?s=200&d=mm&r=g" className="img-circle elevation-2" alt="User Image" />
                            </div>
                            <div className="info">
                                {/*<a href="#" className="d-block">حسام موسوی</a>*/}
                                <a href="#" className="d-block">علی کرمی</a>
                            </div>
                        </div>

                        {/* Sidebar Menu */}
                        <nav className="mt-2">
                            <ul className="nav nav-pills nav-sidebar flex-column" data-widget="treeview" role="menu" data-accordion="false">
                                {/* Add icons to the links using the .nav-icon class
                            with font-awesome or any other icon font library */}
                                <li className="nav-item has-treeview menu-open">
                                    {/*<a href="#" className="nav-link active">
                                        <i className="nav-icon fa fa-dashboard"></i>
                                        <p>
                                            داشبوردها
                                            <i className="right fa fa-angle-left"></i>
                                        </p>
                                    </a>*/}

                                    <NavLink to="/devices" className="nav-link active">
                                        <i className="nav-icon fa fa-dashboard"></i>
                                        <p>
                                            تجهیزات
                            <i className="right fa fa-angle-left"></i>

                                        </p>


                                    </NavLink>
                                    <ul className="nav nav-treeview">
                                        <li className="nav-item">
                                            {/*<a href="./index.html" className="nav-link active">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>داشبورد اول</p>
                                            </a>*/}
                                            <NavLink to="/devices" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p> شناسنامه تجهیزات </p>
                                             </NavLink>
                                        </li>
                        <li className="nav-item">
                          <NavLink to="/LogBookDevices"  className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                            <p> تجهیزات Log Book </p>
                          </NavLink>
                                        </li>
                                        <li className="nav-item">
                                            <a asp-area="" asp-controller="ServiceDevices" asp-action="index" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p> سرویس تجهیزات </p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a asp-area="" asp-controller="DeviceMaintenances" asp-action="index" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p> نگهداری تجهیزات </p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a asp-area="" asp-controller="AutoclaveQualityControls" asp-action="index" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p> اتوکلاو </p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a asp-area="" asp-controller="IncubatorMaintenances" asp-action="index" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p> یخچال/فریزر/انکوباتور </p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a asp-area="" asp-controller="WaterBathMaintenances" asp-action="index" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p> بن ماری </p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a asp-area="" asp-controller="SpectrophotometerMaintenances" asp-action="index" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>  اسپکتروفتومتر </p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a asp-area="" asp-controller="PhotometerMaintenances" asp-action="index" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p> فلیم فتومتر </p>
                                            </a>
                                        </li>
                                        {/*<li className="nav-item">
                                            <a href="./index3.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>داشبورد سوم</p>
                                            </a>
                                        </li>*/}
                                    </ul>
                                </li>
                                <li className="nav-item has-treeview">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-tree"></i>
                                        <p>
                                            پرسنل
                            <i className="fa fa-angle-left right"></i>
                                        </p>
                                    </a>
                                    <ul className="nav nav-treeview">
                                        <li className="nav-item">
                                            {/*<a href="pages/UI/general.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>اصلاعات پرسنل</p>
                                            </a>*/}
                                            <a asp-area="" asp-controller="Users" asp-action="index" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p> اطلاعات پرسنل </p>
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li className="nav-item">
                                    <a href="pages/widgets.html" className="nav-link">
                                        <i className="nav-icon fa fa-th"></i>
                                        <p>
                                            ویجت‌ها
                            <span className="right badge badge-danger">جدید</span>
                                        </p>
                                    </a>
                                </li>
                                <li className="nav-item has-treeview">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-pie-chart"></i>
                                        <p>
                                            چارت‌ها
                            <i className="right fa fa-angle-left"></i>
                                        </p>
                                    </a>
                                    <ul className="nav nav-treeview">
                                        <li className="nav-item">
                                            <a href="pages/charts/chartjs.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>نمودار ChartJS</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/charts/flot.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>نمودار Flot</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/charts/inline.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>نمودار Inline</p>
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li className="nav-item has-treeview">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-tree"></i>
                                        <p>
                                            اشیای گرافیکی
                            <i className="fa fa-angle-left right"></i>
                                        </p>
                                    </a>
                                    <ul className="nav nav-treeview">
                                        <li className="nav-item">
                                            <a href="pages/UI/general.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>عمومی</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/UI/icons.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>آیکون‌ها</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/UI/buttons.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>دکمه‌ها</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/UI/sliders.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>اسلایدر‌ها</p>
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li className="nav-item has-treeview">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-edit"></i>
                                        <p>
                                            فرم‌ها
                            <i className="fa fa-angle-left right"></i>
                                        </p>
                                    </a>
                                    <ul className="nav nav-treeview">
                                        <li className="nav-item">
                                            <a href="pages/forms/general.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>اجزا عمومی</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/forms/advanced.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>پیشرفته</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/forms/editors.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>ویشرایشگر</p>
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li className="nav-item has-treeview">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-table"></i>
                                        <p>
                                            جداول
                            <i className="fa fa-angle-left right"></i>
                                        </p>
                                    </a>
                                    <ul className="nav nav-treeview">
                                        <li className="nav-item">
                                            <a href="pages/tables/simple.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>جداول ساده</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/tables/data.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>جداول داده</p>
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li className="nav-header">مثال‌ها</li>
                                <li className="nav-item">
                                    <a href="pages/calendar.html" className="nav-link">
                                        <i className="nav-icon fa fa-calendar"></i>
                                        <p>
                                            تقویم
                            <span className="badge badge-info right">2</span>
                                        </p>
                                    </a>
                                </li>
                                <li className="nav-item has-treeview">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-envelope-o"></i>
                                        <p>
                                            ایمیل‌ باکس
                            <i className="fa fa-angle-left right"></i>
                                        </p>
                                    </a>
                                    <ul className="nav nav-treeview">
                                        <li className="nav-item">
                                            <a href="pages/mailbox/mailbox.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>اینباکس</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/mailbox/compose.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>ایجاد</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/mailbox/read-mail.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>خواندن</p>
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li className="nav-item has-treeview">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-book"></i>
                                        <p>
                                            صفحات
                            <i className="fa fa-angle-left right"></i>
                                        </p>
                                    </a>
                                    <ul className="nav nav-treeview">
                                        <li className="nav-item">
                                            <a href="pages/examples/invoice.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>سفارشات</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/examples/profile.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>پروفایل</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/examples/login.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>صفحه ورود</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/examples/register.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>صفحه عضویت</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/examples/lockscreen.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>قفل صفحه</p>
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li className="nav-item has-treeview">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-plus-square-o"></i>
                                        <p>
                                            بیشتر
                            <i className="fa fa-angle-left right"></i>
                                        </p>
                                    </a>
                                    <ul className="nav nav-treeview">
                                        <li className="nav-item">
                                            <a href="pages/examples/404.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>ارور 404</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/examples/500.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>ارور 500</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="pages/examples/blank.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>صفحه خالی</p>
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a href="starter.html" className="nav-link">
                                                <i className="fa fa-circle-o nav-icon"></i>
                                                <p>صفحه شروع</p>
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li className="nav-header">متفاوت</li>
                                <li className="nav-item">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-file"></i>
                                        <p>مستندات</p>
                                    </a>
                                </li>
                                <li className="nav-header">برچسب‌ها</li>
                                <li className="nav-item">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-circle-o text-danger"></i>
                                        <p className="text">مهم</p>
                                    </a>
                                </li>
                                <li className="nav-item">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-circle-o text-warning"></i>
                                        <p>هشدار</p>
                                    </a>
                                </li>
                                <li className="nav-item">
                                    <a href="#" className="nav-link">
                                        <i className="nav-icon fa fa-circle-o text-info"></i>
                                        <p>اطلاعات</p>
                                    </a>
                                </li>
                            </ul>
                        </nav>
                        {/* /.sidebar-menu */}
                    </div>
                </div>
                {/* /.sidebar */}
            </aside>
        );
    }
}

export default Sidebar;