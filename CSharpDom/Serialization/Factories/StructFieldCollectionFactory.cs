using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class StructFieldCollectionFactory :
        AbstractFactory<IStructFieldCollection, StructFieldCollection>
    {
        public StructFieldCollectionFactory(IStructFieldCollection fieldCollection)
            : base(fieldCollection)
        {
        }

        public override void VisitStructFieldCollection<TField, TConstant>(
            IStructFieldCollection<TField, TConstant> fieldCollection)
        {
            Value = new StructFieldCollection()
            {
                Fields = fieldCollection.ToList(@field => new StructFieldFactory(@field).Value),
                Constants = fieldCollection.Constants.ToList(constant => new StructConstantFactory(constant).Value)
            };
        }
    }
}
