import * as React from 'react';
//import { data } from '../../DataSource.js';
import { DataManager, WebApiAdaptor, UrlAdaptor } from '@syncfusion/ej2-data';
//import { GridComponent, ColumnsDirective, ColumnDirective, Resize, Sort, ContextMenu, Filter, Page, ExcelExport, PdfExport, Edit, Inject } from '@syncfusion/ej2-react-grids';
//import { DeviceCreateEdit } from './DeviceCreateEdit'
//import ApiURL  from "../../Configs/App.Config";
export default class Create extends React.Component {
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
            <div className='control-pane'>
                <h1>تعریف تجهیزات</h1>
                

           </div>
        );
  }
}
