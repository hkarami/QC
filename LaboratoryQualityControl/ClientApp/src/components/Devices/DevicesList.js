import * as React from 'react';
//import { data } from '../../DataSource.js';
import { DataManager, WebApiAdaptor, UrlAdaptor } from '@syncfusion/ej2-data';
import { GridComponent, ColumnsDirective, ColumnDirective, Page, Inject } from '@syncfusion/ej2-react-grids';

//import ApiURL  from "../../Configs/App.Config";
export default class DevicesList extends React.Component {
    constructor() {
      super(...arguments);
      //this.hostUrl = ApiURL;
      this.data = new DataManager({ url: "https://localhost:44372/api/device", adaptor: new WebApiAdaptor});
    }


    render() {
      return ( 
        <GridComponent id="Grid" dataSource={this.data} ref={grid => this.gridInstance = grid} allowPaging={true} pageSettings={{ pageCount: 3 }}>
          <ColumnsDirective>
                <ColumnDirective field='DeviceCode' width='100' textAlign="Right" />
                <ColumnDirective field='DeviceName' width='100' /> 
            </ColumnsDirective>
        </GridComponent> );
  }
}
