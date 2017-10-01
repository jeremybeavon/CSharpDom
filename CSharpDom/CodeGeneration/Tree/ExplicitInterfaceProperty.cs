using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ExplicitInterfaceProperty
    {
        public ExplicitInterfaceProperty(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public InterfaceReference ExplicitInterface { get; set; }

        public TypeReference Type { get; set; }
        
        public Collection<Statement> GetAccessor { get; set; }

        public Collection<Statement> SetAccessor { get; set; }

        public override string ToString()
        {
            return new ReadOnlyExplicitInterfaceProperty(this).ToSourceCode();
        }
    }
}
