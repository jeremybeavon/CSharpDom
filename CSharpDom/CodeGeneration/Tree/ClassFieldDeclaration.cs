using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassFieldDeclaration
    {
        public ClassMemberVisibilityModifier Visibility { get; set; }

        public bool IsStatic { get; set; }

        public bool IsReadOnly { get; set; }

        public TypeReference Type { get; set; }

        public Collection<Field> Fields { get; set; }
    }
}
