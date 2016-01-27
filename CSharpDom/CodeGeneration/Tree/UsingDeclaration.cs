namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class UsingDeclaration
    {
        public UsingDeclaration(string @namespace)
        {
            Namespace = @namespace;
        }

        public string Namespace { get; set; }
    }
}
