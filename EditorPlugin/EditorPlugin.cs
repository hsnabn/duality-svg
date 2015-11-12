using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality.Editor;

namespace DualitySVG.Editor
{
    // Defines a Duality editor plugin.
    public class DualitySVGEditorPlugin : EditorPlugin
    {
        public override string Id
        {
            get { return "DualitySVGEditorPlugin"; }
        }
    }
}
