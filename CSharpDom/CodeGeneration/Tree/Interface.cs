using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Interface
    {
        public Interface(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            GenericParameters = new Collection<GenericParameter>();
            Interfaces = new Collection<InterfaceReference>();
            Body = new InterfaceBody();
            Visibility = TypeVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public TypeVisibilityModifier Visibility { get; set; }

        public bool IsPartial { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<InterfaceReference> Interfaces { get; set; }

        public InterfaceBody Body { get; set; }

        public override string ToString()
        {
            return new ReadOnlyInterface(this).ToSourceCode();
        }
    }
}
