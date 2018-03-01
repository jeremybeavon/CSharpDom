using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class StaticClassPropertyCollectionFactory :
        AbstractFactory<IStaticClassPropertyCollection, StaticClassPropertyCollection>
    {
        public StaticClassPropertyCollectionFactory(IStaticClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitStaticClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty>(
            IStaticClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty> propertyCollection)
        {
            Value = new StaticClassPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new StaticClassPropertyFactory(property).Value),
                AutoProperties = propertyCollection.AutoProperties.ToList(property => new StaticClassAutoPropertyFactory(property).Value),
                LambdaProperties = propertyCollection.LambdaProperties.ToList(property => new StaticClassLambdaPropertyFactory(property).Value)
            };
        }
    }
}
