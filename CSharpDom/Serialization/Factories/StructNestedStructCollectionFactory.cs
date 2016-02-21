using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructNestedStructCollectionFactory : 
        AbstractFactory<IStructNestedStructCollection, StructNestedStructCollection>
    {
        public StructNestedStructCollectionFactory(IStructNestedStructCollection collection)
            : base(collection)
        {
        }

        public override void VisitStructNestedStructCollection<TStruct, TPartialStruct>(
            IStructNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Value = new StructNestedStructCollection()
            {
                Structs = structCollection.ToList(@struct => new StructNestedStructFactory(@struct).Value)
            };
        }
    }
}
