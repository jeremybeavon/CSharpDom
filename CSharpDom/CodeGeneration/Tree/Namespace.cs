using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Namespace : TypeContainer
    {
        public Namespace(string name)
        {
            Name = name;
            Usings = new Collection<UsingDeclaration>();
            Namespaces = new Collection<Namespace>();
        }

        public Collection<UsingDeclaration> Usings { get; set; }

        public string Name { get; set; }

        public Collection<Namespace> Namespaces { get; set; }
    }
}
