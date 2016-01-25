using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Struct
    {
        public Struct(string name)
        {
            Name = name;
            GenericParameters = new Collection<GenericParameter>();
            Interfaces = new Collection<InterfaceReference>();
            Body = new StructBody();
        }

        public string Name { get; set; }

        public TypeVisibilityModifier Visibility { get; set; }

        public bool IsPartial { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<InterfaceReference> Interfaces { get; set; }

        public StructBody Body { get; set; }
    }
}
