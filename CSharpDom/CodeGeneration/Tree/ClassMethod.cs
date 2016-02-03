using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassMethod
    {
        public ClassMethod(string name)
        {
            Name = name;
            GenericParameters = new Collection<GenericParameter>();
            Parameters = new Collection<ClassMethodParameter>();
            Body = new Collection<Statement>();
        }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public bool IsAsync { get; set; }

        public bool IsPartial { get; set; }

        public ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public TypeReference ReturnType { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<ClassMethodParameter> Parameters { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
