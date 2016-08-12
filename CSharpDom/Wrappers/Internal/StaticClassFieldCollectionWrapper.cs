using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StaticClassFieldCollectionWrapper :
        AbstractWrapper<IStaticClassFieldCollection>
    {
        public StaticClassFieldCollectionWrapper(IStaticClassFieldCollection fieldCollection)
            : base(fieldCollection)
        {
        }

        public override void VisitStaticClassFieldCollection<TField, TConstant>(
            IStaticClassFieldCollection<TField, TConstant> fieldCollection)
        {
            Value = new StaticClassFieldCollection()
            {
                Fields = fieldCollection.ToList(@field => new StaticClassFieldWrapper(@field).Value),
                Constants = fieldCollection.Constants.ToList(constant => new StaticClassConstantWrapper(constant).Value)
            };
        }
    }
}
