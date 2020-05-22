import * as React from 'react';
//import { data } from '../../DataSource.js';
import { DataManager, WebApiAdaptor, UrlAdaptor } from '@syncfusion/ej2-data';
import { GridComponent, ColumnsDirective, ColumnDirective, Resize, Sort, ContextMenu, Filter, Page, ExcelExport, PdfExport, Edit, Inject } from '@syncfusion/ej2-react-grids';

//import ApiURL  from "../../Configs/App.Config";
export default class DevicesList extends React.Component {
    constructor() {
      super(...arguments);
      //this.hostUrl = ApiURL;
      this.data = new DataManager({ url: "https://localhost:44372/api/device", adaptor: new WebApiAdaptor });
      document.title = "تجهیزات";
      this.groupOptions = { showGroupedColumn: true };
      this.contextMenuItems = ['AutoFit', 'AutoFitAll',
        'SortAscending', 'SortDescending', 'Copy', 'Edit', 'Delete', 'Save',
        'Cancel', 'PdfExport', 'ExcelExport', 'CsvExport', 'FirstPage', 'PrevPage',
        'LastPage', 'NextPage'];
      this.editing = { allowDeleting: true, allowEditing: true };
    }


    render() {
      return ( 
        <GridComponent id="Grid" dataSource={this.data} ref={grid => this.gridInstance = grid} allowPaging={true} pageSettings={{ pageCount: 3 }} allowSorting={true} allowExcelExport={true} allowPdfExport={true} contextMenuItems={this.contextMenuItems} editSettings={this.editing}>
          <ColumnsDirective>
            <ColumnDirective type='checkbox' allowSorting={false} allowFiltering={false} width='50'></ColumnDirective>
            <ColumnDirective field='DeviceCode' headerText='کد دستگاه' width='70' textAlign="Right" />
            <ColumnDirective field='DeviceName' headerText='نام دستگاه' width='100' /> 
            <ColumnDirective field='DeviceTypeName' headerText='نوع دستگاه' width='80' /> 
            <ColumnDirective field='LaboratorySectionName' headerText='بخش' width='100' /> 
            <ColumnDirective field='SupportCompany' headerText='شرکت پشتیبان' width='130'   /> 
            <ColumnDirective field='PhoneToSupportCompany' headerText='تلفن شرکت پشتیبان' width='100' />     
            <ColumnDirective field='UserFullName' headerText='کاربر' width='100' /> 
          </ColumnsDirective>
          <Inject services={[Resize, Sort, ContextMenu, Filter, Page, ExcelExport, Edit, PdfExport]} />
        </GridComponent> );
  }
}
