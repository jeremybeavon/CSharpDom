using CSharpDom.Common;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ExplicitInterfaceIndexer
    {
        public ExplicitInterfaceIndexer()
        {
            Parameters = new Collection<MethodParameter>();
        }
        
        public TypeReference Type { get; set; }

        public InterfaceReference ExplicitInterface { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }
        
        public Collection<Statement> GetAccessor { get; set; }

        public Collection<Statement> SetAccessor { get; set; }
    }
}
