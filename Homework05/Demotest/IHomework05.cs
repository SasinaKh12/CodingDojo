using System;
using System.Collections.Generic;
using System.Text;

namespace Demotest
{
    public interface IHomework05
    {
        string DisplayLEDOnScreen(string lednum);
        string LoadState();
        void SaveCurrentState();
        void SetAppConfigurations(string onSymbol, string offSymbol, int spacing);
        
    }
}
