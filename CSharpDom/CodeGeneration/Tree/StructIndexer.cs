using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructIndexer
    {
        public StructIndexer()
        {
            Attributes = new Collection<AttributeGroup>();
            Parameters = new Collection<MethodParameter>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public TypeReference Type { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public StructAccessor GetAccessor { get; set; }

        public StructAccessor SetAccessor { get; set; }
    }
}
