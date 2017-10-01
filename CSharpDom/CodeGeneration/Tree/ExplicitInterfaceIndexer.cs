using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Common;
using CSharpDom.Text;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ExplicitInterfaceIndexer
    {
        public ExplicitInterfaceIndexer()
        {
            Attributes = new Collection<AttributeGroup>();
            Parameters = new Collection<MethodParameter>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public TypeReference Type { get; set; }

        public InterfaceReference ExplicitInterface { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }
        
        public Collection<Statement> GetAccessor { get; set; }

        public Collection<Statement> SetAccessor { get; set; }

        public override string ToString()
        {
            return new ReadOnlyExplicitInterfaceIndexer(this).ToSourceCode();
        }
    }
}
