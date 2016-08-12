using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructCollectionWrapper : AbstractWrapper<IStructCollection>
    {
        public StructCollectionWrapper(IStructCollection field)
            : base(field)
        {
        }

        public override void VisitStructCollection<TStruct, TPartialStruct>(
            IStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Value = new StructCollection()
            {
                Structs = structCollection.ToList(@class => new StructWrapper(@class).Value)
            };
        }
    }
}
