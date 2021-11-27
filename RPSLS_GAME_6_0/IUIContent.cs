using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal interface IUIContent
    {
        string UITitle { get; set; }
        string UIWelcomeMessage { get; set; }
        string UINavigationMessage { get; set; }
        string UIWaitForInputMessage { get; set; }
        string UIHitValidKeyMessage { get; set; }
        void WriteUIToTheConsole();

    }
}
