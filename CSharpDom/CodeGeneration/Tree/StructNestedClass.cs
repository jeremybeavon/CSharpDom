using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructNestedClass
    {
        public StructNestedClass(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            GenericParameters = new Collection<GenericParameter>();
            Interfaces = new Collection<InterfaceReference>();
            Body = new ClassBody();
            Visibility = StructMemberVisibilityModifier.Private;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }
        
        public Collection<GenericParameter> GenericParameters { get; set; }

        public ClassReference BaseClass { get; set; }

        public Collection<InterfaceReference> Interfaces { get; set; }

        public ClassBody Body { get; set; }
    }
}
