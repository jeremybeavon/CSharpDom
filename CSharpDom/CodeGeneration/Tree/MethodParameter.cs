using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class MethodParameter
    {
        public MethodParameter(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
        }

        public MethodParameter(string name, TypeReference type)
            : this(name)
        {
            Type = type;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public ParameterModifier Modifier { get; set; }

        public TypeReference Type { get; set; }
    }
}
