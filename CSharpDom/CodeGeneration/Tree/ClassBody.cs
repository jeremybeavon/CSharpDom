using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassBody
    {
        public ClassBody()
        {
            Fields = new Collection<ClassFieldDeclaration>();
        }

        public Collection<ClassFieldDeclaration> Fields { get; set; }

        public Collection<ClassMethod> Methods { get; set; }
    }
}
