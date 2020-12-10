import * as React from 'react';
//import { data } from '../../DataSource.js';
import { TextBoxComponent } from '@syncfusion/ej2-react-inputs';
import { ComboBoxComponent } from '@syncfusion/ej2-react-dropdowns';
import { DataManager, WebApiAdaptor, UrlAdaptor } from '@syncfusion/ej2-data';
//import { GridComponent, ColumnsDirective, ColumnDirective, Resize, Sort, ContextMenu, Filter, Page, ExcelExport, PdfExport, Edit, Inject } from '@syncfusion/ej2-react-grids';

//import ApiURL  from "../../Configs/App.Config";
export default class DeviceCreateEdit extends React.Component {
    constructor() {
      super(...arguments);
      //this.hostUrl = ApiURL;
        this.deviceTypes = new DataManager({ url: "https://localhost:44372/api/devicetypes/", adaptor: new WebApiAdaptor });
        this.localFields = { text: 'DeviceTypeName', value: 'DeviceTypeID' };
        this.laboratorySections = new DataManager({ url: "https://localhost:44372/api/LaboratorySections/", adaptor: new WebApiAdaptor });
        this.FieldslaboratorySections = { text: 'SectionNameLab', value: 'SectionCodeLab' };
        document.title = "تجهیزات";
    }


    render() {
        return ( 
            <div className='control-pane'>
                <div className='control-section input-content-wrapper'>
                    <div className="row custom-margin custom-padding-5 material2">
                        <div className="col">
                            <TextBoxComponent placeholder="نام دستگاه" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col">
                            <ComboBoxComponent id="DeviceType" placeholder="نوع دستگاه" dataSource={this.deviceTypes} fields={this.localFields} popupHeight="220px" />
                        </div>
                        <div className="col">
                            <TextBoxComponent placeholder="کارخانه" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col">
                            <TextBoxComponent placeholder="مدل" cssClass="e-outline" floatLabelType="Auto" />
                        </div>                 
                    </div>
                    <div className="row custom-margin custom-padding-5 material2">
                        <div className="col">
                            <TextBoxComponent placeholder="کشور سازنده" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col">
                            <TextBoxComponent placeholder="شماره سریال" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col">
                            <TextBoxComponent placeholder="شرکت پشتیبان" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col">
                            <TextBoxComponent placeholder="محل استقرار" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                    </div>
                    <div className="row custom-margin custom-padding-5 material2">
                        <div className="col">
                            <TextBoxComponent placeholder="کاربران وِیژه" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col">
                            <TextBoxComponent placeholder=" کد شناسایی" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col">
                            <TextBoxComponent placeholder="تاریخ رسید به آزمایشگاه " cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col">
                            <TextBoxComponent placeholder="تاریخ راه اندازی در آزمایشگاه" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                    </div>
                    <div className="row custom-margin custom-padding-5 material2">
                        <div className="col">
                            <TextBoxComponent placeholder="شرایط دستگاه در موقع تحویل " cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col">
                            <TextBoxComponent placeholder=" ویژگی خاص  " cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col">
                            <TextBoxComponent placeholder="تجهیزات مرتبط " cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                        <div className="col">
                            <TextBoxComponent placeholder="تلفن تماس با شرکت پشتیبان" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                    </div>
                    <div className="row custom-margin custom-padding-5 material2">
                        <div className="col-3">
                            <ComboBoxComponent id="LaboratorySections" placeholder="بخش آزمایشگاه" dataSource={this.laboratorySections} fields={this.FieldslaboratorySections} popupHeight="220px" />
                        </div>
                        <div className="col-9">
                            <TextBoxComponent placeholder="سایر" cssClass="e-outline" floatLabelType="Auto" />
                        </div>
                    </div>
                </div>
            </div>
        );
  }
}
