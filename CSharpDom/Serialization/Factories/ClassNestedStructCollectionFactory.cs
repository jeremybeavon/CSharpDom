using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassNestedStructCollectionFactory : AbstractFactory<IClassNestedStructCollection, ClassNestedStructCollection>
    {
        public ClassNestedStructCollectionFactory(IClassNestedStructCollection collection)
            : base(collection)
        {
        }

        public override void VisitClassNestedStructCollection<TStruct, TPartialStruct>(
            IClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Value = new ClassNestedStructCollection()
            {
                Structs = structCollection.ToList(@struct => new ClassNestedStructFactory(@struct).Value)
            };
        }
    }
}
