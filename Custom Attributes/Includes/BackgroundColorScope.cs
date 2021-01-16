using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary> 컨트롤 색상 변경 </summary>
    public class BackgroundColorScope : GUI.Scope
    {
        private readonly Color color;

        public BackgroundColorScope(Color color)
        {
            this.color = GUI.backgroundColor;
            GUI.backgroundColor = color;
        }

        protected override void CloseScope()
        {
            GUI.backgroundColor = color;
        }
    }
}
