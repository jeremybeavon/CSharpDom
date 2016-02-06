using CSharpDom.Common;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class AbstractIndexer
    {
        public AbstractIndexer()
        {
            Parameters = new Collection<MethodParameter>();
        }
        
        public ClassMemberVisibilityModifier Visibility { get; set; }
        
        public TypeReference Type { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public EmptyClassPropertyAccessors EmptyAccessors { get; set; }
    }
}
