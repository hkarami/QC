import 'bootstrap/dist/css/bootstrap.css';
import './App.css';
import React, { Component } from 'react';
import { BrowserRouter } from 'react-router-dom';
import { Layout } from './components/Layout/Layout';
import Routes from './components/Layout/Routes';
const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <BrowserRouter basename={baseUrl}>
                <Layout >
                    <Routes />
                </Layout>
            </BrowserRouter>
        );
    }
}



