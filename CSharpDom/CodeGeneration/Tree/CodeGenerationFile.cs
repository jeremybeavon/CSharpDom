using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class CodeGenerationFile : TypeContainer
    {
        public CodeGenerationFile()
        {
            Usings = new Collection<UsingDeclaration>();
            Namespaces = new Collection<Namespace>();
        }

        public Collection<UsingDeclaration> Usings { get; set; }

        public Collection<Namespace> Namespaces { get; set; }
    }
}
