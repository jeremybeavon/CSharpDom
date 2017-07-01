using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticClassNestedInterface
    {
        public StaticClassNestedInterface(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            GenericParameters = new Collection<GenericParameter>();
            Interfaces = new Collection<InterfaceReference>();
            Body = new InterfaceBody();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public bool ISPartial { get; set; }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }
        
        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<InterfaceReference> Interfaces { get; set; }

        public InterfaceBody Body { get; set; }
    }
}
