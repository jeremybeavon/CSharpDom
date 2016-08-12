using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class ClassFieldCollectionWrapper :
        AbstractWrapper<IClassFieldCollection>
    {
        public ClassFieldCollectionWrapper(IClassFieldCollection fieldCollection)
            : base(fieldCollection)
        {
        }

        public override void VisitClassFieldCollection<TField, TConstant>(
            IClassFieldCollection<TField, TConstant> fieldCollection)
        {
            Value = new ClassFieldCollection()
            {
                Fields = fieldCollection.ToList(@field => new ClassFieldWrapper(@field).Value),
                Constants = fieldCollection.Constants.ToList(constant => new ClassConstantWrapper(constant).Value)
            };
        }
    }
}
