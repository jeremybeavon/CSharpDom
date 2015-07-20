using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassPropertyAccessor
    {
        public ClassPropertyAccessor()
        {
            Body = new BlockStatement();
        }

        public ClassPropertyAccessorVisibilityModifier Visibility { get; set; }

        public BlockStatement Body { get; set; }
    }
}
