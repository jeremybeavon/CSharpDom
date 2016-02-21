using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassNestedStructCollectionFactory :
        AbstractFactory<IStaticClassNestedStructCollection, StaticClassNestedStructCollection>
    {
        public StaticClassNestedStructCollectionFactory(IStaticClassNestedStructCollection collection)
            : base(collection)
        {
        }

        public override void VisitStaticClassNestedStructCollection<TStruct, TPartialStruct>(
            IStaticClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Value = new StaticClassNestedStructCollection()
            {
                Structs = structCollection.ToList(@struct => new StaticClassNestedStructFactory(@struct).Value)
            };
        }
    }
}
