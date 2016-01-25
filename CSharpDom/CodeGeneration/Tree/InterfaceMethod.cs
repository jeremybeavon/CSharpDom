using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class InterfaceMethod
    {
        public InterfaceMethod(string name)
        {
            Name = name;
            GenericParameters = new Collection<GenericParameter>();
            Parameters = new Collection<MethodParameter>();
        }

        public string Name { get; set; }

        public bool IsNew { get; set; }

        public TypeReference ReturnType { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }
    }
}
