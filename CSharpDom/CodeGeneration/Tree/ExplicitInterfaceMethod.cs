using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ExplicitInterfaceMethod
    {
        public ExplicitInterfaceMethod(string name)
        {
            Name = name;
            Parameters = new Collection<MethodParameter>();
            Body = new Collection<Statement>();
        }

        public string Name { get; set; }

        public bool IsAsync { get; set; }

        public InterfaceReference ExplicitInterface { get; set; }

        public TypeReference ReturnType { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
