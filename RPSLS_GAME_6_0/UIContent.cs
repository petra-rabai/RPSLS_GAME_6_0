using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal class UIContent : IUIContent
    {
        private const string Title = "Welcome to the RPSLS Game";
        private string uITitle = Title;

        public string UITitle { get => uITitle; set => uITitle = value; }
        public string UIWelcomeMessage { get; set; }
        public string UINavigationMessage { get; set; }
        public string UIWaitForInputMessage { get; set; }
        public string UIHitValidKeyMessage { get; set; }
    }
}
