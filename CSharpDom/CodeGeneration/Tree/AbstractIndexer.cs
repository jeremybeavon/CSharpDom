using CSharpDom.Common;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class AbstractIndexer
    {
        public AbstractIndexer()
        {
            Attributes = new Collection<AttributeGroup>();
            Parameters = new Collection<MethodParameter>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }
        
        public TypeReference Type { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public EmptyClassPropertyAccessors EmptyAccessors { get; set; }
    }
}
