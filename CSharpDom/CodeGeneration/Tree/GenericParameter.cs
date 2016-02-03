using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class GenericParameter
    {
        public GenericParameter(string name)
        {
            Name = name;
            GenericParameterConstraints = new Collection<GenericParameterReference>();
            InterfaceConstraints = new Collection<InterfaceReference>();
        }

        public string Name { get; set; }

        public GenericParameterDeclarationDirection Direction { get; set; }

        public GenericParameterTypeConstraint TypeConstraint { get; set; }

        public ClassReference BaseClassConstraint { get; set; }

        public Collection<GenericParameterReference> GenericParameterConstraints { get; set; }

        public Collection<InterfaceReference> InterfaceConstraints { get; set; }

        public bool HasEmptyConstructorConstraint { get; set; }
    }
}
