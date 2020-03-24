using System;
using System.Collections.Generic;
using System.Text;

namespace SimonaApp1
{
  public  class Generator
    {
        public event EventHandler<State> StateChanged;


        public void Ogon()
        {
            OnStateChanged(new State { StateName = "Connected" });
        }

        private void OnStateChanged(State state)
        {
            StateChanged.Invoke(this, state);
        }
    }
}
