namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EnumField
    {
        public EnumField(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string RawInitialValue { get; set; }
    }
}
