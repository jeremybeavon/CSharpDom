using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructNestedStruct
    {
        public StructNestedStruct(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            Body = new StructBody();
            GenericParameters = new Collection<GenericParameter>();
            Interfaces = new Collection<InterfaceReference>();
            Visibility = StructMemberVisibilityModifier.Private;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }
        
        public bool IsPartial { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<InterfaceReference> Interfaces { get; set; }

        public StructBody Body { get; set; }
    }
}
