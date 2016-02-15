using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticClassMethod
    {
        public StaticClassMethod(string name)
        {
            Name = name;
            GenericParameters = new Collection<GenericParameter>();
            Parameters = new Collection<MethodParameter>();
            Body = new Collection<Statement>();
        }

        public string Name { get; set; }

        public StaticClassMemberVisibilityModifier Visibility { get; set; }
        
        public TypeReference ReturnType { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
