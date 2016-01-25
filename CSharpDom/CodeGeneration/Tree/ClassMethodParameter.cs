namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassMethodParameter
    {
        public ClassMethodParameter(string name)
        {
            Name = name;
        }

        public ClassMethodParameter(string name, TypeReference type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }

        public ClassMethodParameterModifier Modifier { get; set; }

        public TypeReference Type { get; set; }
    }
}
