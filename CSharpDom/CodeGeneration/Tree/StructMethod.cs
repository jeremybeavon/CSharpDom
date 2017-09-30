using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructMethod
    {
        public StructMethod(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            GenericParameters = new Collection<GenericParameter>();
            Parameters = new Collection<MethodParameter>();
            Body = new Collection<Statement>();
            Visibility = StructMemberVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public StructMethodInheritanceModifier InheritanceModifier { get; set; }

        public bool IsAsync { get; set; }

        public TypeReference ReturnType { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public Collection<Statement> Body { get; set; }
    }
}
