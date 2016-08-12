using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedStructCollectionWrapper :
        AbstractWrapper<IStaticClassNestedStructCollection>
    {
        public StaticClassNestedStructCollectionWrapper(IStaticClassNestedStructCollection collection)
            : base(collection)
        {
        }

        public override void VisitStaticClassNestedStructCollection<TStruct, TPartialStruct>(
            IStaticClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Value = new StaticClassNestedStructCollection()
            {
                Structs = structCollection.ToList(@struct => new StaticClassNestedStructWrapper(@struct).Value)
            };
        }
    }
}
