using System;
using System.Collections.Generic;
using System.Text;

namespace Demotest
{
    interface IHomework06
    {
        string DisplayLEDOnScreen(string ledNo);
        string LoadState();
        void SaveCurrentState();
        void SetAppConfigurations(string onSymbol, string offSymbol, int spacing);
    }
}
