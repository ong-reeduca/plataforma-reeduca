import React from 'react';
import { Route, Switch } from 'react-router-dom';

import Home from './components/Home/Home';
import Aux from './hoc/Aux/Aux';

function App() {
  return (
    <Aux>
      <Switch>
        <Route path="/" exact component={Home} />
      </Switch>
    </Aux>
  );
}

export default App;
