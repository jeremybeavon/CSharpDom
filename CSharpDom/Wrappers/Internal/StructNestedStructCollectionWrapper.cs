using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedStructCollectionWrapper : 
        AbstractWrapper<IStructNestedStructCollection>
    {
        public StructNestedStructCollectionWrapper(IStructNestedStructCollection collection)
            : base(collection)
        {
        }

        public override void VisitStructNestedStructCollection<TStruct, TPartialStruct>(
            IStructNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Value = new StructNestedStructCollection()
            {
                Structs = structCollection.ToList(@struct => new StructNestedStructWrapper(@struct).Value)
            };
        }
    }
}
