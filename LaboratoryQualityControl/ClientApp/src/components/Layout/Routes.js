import React from 'react';


import { Route, Redirect, Switch } from 'react-router-dom';
import DevicesList from '../Devices/DevicesList';
//import Create from '../Devices/Create';
import Create from '../Devices/Create'
function Routes(props) {
    return (
        <Switch>
            <Route component={DevicesList} path='/Devices' exact />
            <Route component={Create} path='/Devices/Create' exact />
            {/*<Route component='' path='/LogBookDevices' />
            <Route component='' path='/ServiceDevices' />
            
            <Route component='' path='/DeviceMaitances' />
            <Route component='' path='/AutoClaveQualityControls' />
            <Route component='' path='/IncubatorMaintenances' />
            <Route component='' path='/WaterBathMaintenances' />
            <Route component='' path='/SpectrophotometerMaintenances' />
            <Route component='' path='/PhotometerMaintenances' />
            <Route component='' path='/PhotometerM]aintenances' />
            <Route component='' path='/Users' />
            <Redirect to="/" />*/}
        </Switch>
    );
}

export default Routes;