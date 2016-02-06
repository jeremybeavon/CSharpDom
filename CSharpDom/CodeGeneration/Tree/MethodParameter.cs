namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class MethodParameter
    {
        public MethodParameter(string name)
        {
            Name = name;
        }

        public MethodParameter(string name, TypeReference type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }

        public ParameterModifier Modifier { get; set; }

        public TypeReference Type { get; set; }
    }
}
