using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ExplicitInterfaceProperty
    {
        public ExplicitInterfaceProperty(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public InterfaceReference ExplicitInterface { get; set; }

        public TypeReference Type { get; set; }
        
        public Collection<Statement> GetAccessor { get; set; }

        public Collection<Statement> SetAccessor { get; set; }
    }
}
