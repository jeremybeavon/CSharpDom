using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StructFieldCollectionWrapper :
        AbstractWrapper<IStructFieldCollection>
    {
        public StructFieldCollectionWrapper(IStructFieldCollection fieldCollection)
            : base(fieldCollection)
        {
        }

        public override void VisitStructFieldCollection<TField, TConstant>(
            IStructFieldCollection<TField, TConstant> fieldCollection)
        {
            Value = new StructFieldCollection()
            {
                Fields = fieldCollection.ToList(@field => new StructFieldWrapper(@field).Value),
                Constants = fieldCollection.Constants.ToList(constant => new StructConstantWrapper(constant).Value)
            };
        }
    }
}
