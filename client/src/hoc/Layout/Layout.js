import React, { Component } from 'react';

import Aux from '../Aux/Aux';

class Layout extends Component {
    render () {
        return (
            <Aux>
                {this.props.children}
            </Aux>
        );
    }
}

export default Layout;