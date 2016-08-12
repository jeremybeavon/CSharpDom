using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassNestedStructCollectionWrapper : AbstractWrapper<IClassNestedStructCollection>
    {
        public ClassNestedStructCollectionWrapper(IClassNestedStructCollection collection)
            : base(collection)
        {
        }

        public override void VisitClassNestedStructCollection<TStruct, TPartialStruct>(
            IClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Value = new ClassNestedStructCollection()
            {
                Structs = structCollection.ToList(@struct => new ClassNestedStructWrapper(@struct).Value)
            };
        }
    }
}
