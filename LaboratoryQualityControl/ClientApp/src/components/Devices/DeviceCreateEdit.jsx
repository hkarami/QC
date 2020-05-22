import * as React from 'react';
//import { data } from '../../DataSource.js';
import { TextBoxComponent } from '@syncfusion/ej2-react-inputs';
import { DataManager, WebApiAdaptor, UrlAdaptor } from '@syncfusion/ej2-data';
//import { GridComponent, ColumnsDirective, ColumnDirective, Resize, Sort, ContextMenu, Filter, Page, ExcelExport, PdfExport, Edit, Inject } from '@syncfusion/ej2-react-grids';

//import ApiURL  from "../../Configs/App.Config";
export default class DeviceCreateEdit extends React.Component {
    constructor() {
      super(...arguments);
      //this.hostUrl = ApiURL;
      //this.data = new DataManager({ url: "https://localhost:44372/api/device", adaptor: new WebApiAdaptor });
      
      //this.groupOptions = { showGroupedColumn: true };
      //this.contextMenuItems = ['AutoFit', 'AutoFitAll',
      //  'SortAscending', 'SortDescending', 'Copy', 'Edit', 'Delete', 'Save',
      //  'Cancel', 'PdfExport', 'ExcelExport', 'CsvExport', 'FirstPage', 'PrevPage',
      //  'LastPage', 'NextPage'];
      //this.editing = { allowDeleting: true, allowEditing: true };

        document.title = "تجهیزات";
    }


    render() {
        return ( 
            <div className='control-pane'>
                <div className='control-section input-content-wrapper'>
                    <div className="row custom-margin material2">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6"><b>Outlined and Filled</b></div>
                    </div>
                    <div className="row custom-margin custom-padding-5 material2">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <TextBoxComponent placeholder="Outlined" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <TextBoxComponent placeholder="Filled" cssClass="e-filled" floatLabelType="Auto" />
                        </div>
                    </div>
                    <div className="row custom-margin">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6"><b>Floating Label</b></div>
                    </div>
                    <div className="row custom-margin custom-padding-5">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <TextBoxComponent placeholder="First Name" floatLabelType="Auto" />
                        </div>
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <TextBoxComponent placeholder="Last Name" floatLabelType="Auto" enableRtl={true} />
                        </div>
                    </div>
                    <div className="row custom-margin custom-padding-5">
                        <div className="col-xs-12 col-sm-12 col-lg-12 col-md-12">
                            <div className="e-float-input e-input-group">
                                <input type="text" onFocus={this.floatFocus} onBlur={this.floatBlur} required />
                                <span className="e-float-line"></span>
                                <label className="e-float-text">Country</label>
                                <span className="e-input-group-icon e-spin-down" onMouseDown={this.onIconClick} onMouseUp={this.onIconUnClick}></span>
                            </div>
                        </div>
                    </div>
                    <div className="row custom-margin">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6"><b>Inputs</b></div>
                    </div>
                    <div className="row custom-margin">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <div className="e-input-group">
                                <input className="e-input" type="text" onFocus={this.floatFocus} onBlur={this.floatBlur} placeholder="Enter Name" />
                            </div>
                        </div>
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <div className="e-input-group e-rtl">
                                <input className="e-input" onFocus={this.floatFocus} onBlur={this.floatBlur} type="text" placeholder="Last Name" />
                            </div>
                        </div>
                    </div>
                    <div className="row custom-margin">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <div className="e-input-group">
                                <input className="e-input" onFocus={this.floatFocus} onBlur={this.floatBlur} type="password" placeholder="Password" defaultValue="password" />
                            </div>
                        </div>
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <div className="e-input-group">
                                <input className="e-input" onFocus={this.floatFocus} onBlur={this.floatBlur} type="email" placeholder="Enter Email" />
                            </div>
                        </div>
                    </div>
                    <div className="row custom-margin">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <div className="e-input-group e-disabled">
                                <input className="e-input" onFocus={this.floatFocus} onBlur={this.floatBlur} type="text" placeholder="Disabled" disabled />
                            </div>
                        </div>
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <div className="e-input-group">
                                <input className="e-input" onFocus={this.floatFocus} onBlur={this.floatBlur} type="text" placeholder="Enter Name" value="Readonly" readOnly />
                            </div>
                        </div>
                    </div>
                    <div className="row custom-margin">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6"><b>Validation States</b></div>
                    </div>
                    <div className="row custom-margin">
                        <div className="col-xs-4 col-sm-4 col-lg-4 col-md-4">
                            <div className="e-input-group e-success">
                                <input className="e-input" onFocus={this.floatFocus} onBlur={this.floatBlur} type="text" placeholder="Success" />
                            </div>
                        </div>
                        <div className="col-xs-4 col-sm-4 col-lg-4 col-md-4">
                            <div className="e-input-group e-warning">
                                <input className="e-input" type="text" onFocus={this.floatFocus} onBlur={this.floatBlur} placeholder="Warning" />
                            </div>
                        </div>
                        <div className="col-xs-4 col-sm-4 col-lg-4 col-md-4">
                            <div className="e-input-group e-error">
                                <input className="e-input" onFocus={this.floatFocus} onBlur={this.floatBlur} type="text" placeholder="Error" />
                            </div>
                        </div>
                    </div>
                    <div className="row custom-margin">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6"><b>Sizing</b></div>
                    </div>
                    <div className="row custom-margin">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <div className="e-input-group e-small">
                                <input className="e-input" onFocus={this.floatFocus} onBlur={this.floatBlur} type="text" placeholder="Small" />
                            </div>
                        </div>
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <div className="e-input-group">
                                <input className="e-input" onFocus={this.floatFocus} onBlur={this.floatBlur} type="text" placeholder="Normal" />
                            </div>
                        </div>
                    </div>
                    <div className="row custom-margin">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6"><b>Input & Elements</b></div>
                    </div>
                    <div className="row custom-margin">
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <div className="e-input-group">
                                <input className="e-input" onFocus={this.floatFocus} onBlur={this.floatBlur} type="text" placeholder="Date of Birth" />
                                <span className="e-input-group-icon e-input-calendar" onMouseDown={this.onIconClick} onMouseUp={this.onIconUnClick}></span>
                            </div>
                        </div>
                        <div className="col-xs-6 col-sm-6 col-lg-6 col-md-6">
                            <div className="e-input-group e-float-icon-left">
                                <span className="e-input-group-icon e-input-picture" onMouseDown={this.onIconClick} onMouseUp={this.onIconUnClick}></span>
                                <div className="e-input-in-wrap">
                                    <input className="e-input" onFocus={this.floatFocus} onBlur={this.floatBlur} type="text" placeholder="Upload Picture" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
  }
}
