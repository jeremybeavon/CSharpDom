using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructCollectionFactory : AbstractFactory<IStructCollection, StructCollection>
    {
        public StructCollectionFactory(IStructCollection field)
            : base(field)
        {
        }

        public override void VisitStructCollection<TStruct, TPartialStruct>(
            IStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Value = new StructCollection()
            {
                Structs = structCollection.ToList(@class => new StructFactory(@class).Value)
            };
        }
    }
}
