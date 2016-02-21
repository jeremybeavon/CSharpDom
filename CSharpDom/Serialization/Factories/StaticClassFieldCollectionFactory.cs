using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class StaticClassFieldCollectionFactory :
        AbstractFactory<IStaticClassFieldCollection, StaticClassFieldCollection>
    {
        public StaticClassFieldCollectionFactory(IStaticClassFieldCollection fieldCollection)
            : base(fieldCollection)
        {
        }

        public override void VisitStaticClassFieldCollection<TField, TConstant>(
            IStaticClassFieldCollection<TField, TConstant> fieldCollection)
        {
            Value = new StaticClassFieldCollection()
            {
                Fields = fieldCollection.ToList(@field => new StaticClassFieldFactory(@field).Value),
                Constants = fieldCollection.Constants.ToList(constant => new StaticClassConstantFactory(constant).Value)
            };
        }
    }
}
