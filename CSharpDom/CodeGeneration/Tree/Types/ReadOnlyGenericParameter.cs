using CSharpDom.BaseClasses;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyGenericParameter : AbstractGenericParameter<ReadOnlyTypeReference>
    {
        private readonly ReadOnlyTypeReference type;

        public ReadOnlyGenericParameter(TypeReference typeReference)
        {
            type = new ReadOnlyTypeReference(typeReference);
        }

        public static IReadOnlyList<ReadOnlyGenericParameter> Create(IEnumerable<TypeReference> typeReferences)
        {
            return typeReferences.ToArray(type => new ReadOnlyGenericParameter(type));
        }

        public override ReadOnlyTypeReference Type
        {
            get { return type; }
        }
    }
}
