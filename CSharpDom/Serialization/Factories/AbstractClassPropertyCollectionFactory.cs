using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class AbstractClassPropertyCollectionFactory :
        AbstractFactory<IAbstractClassPropertyCollection, AbstractClassPropertyCollection>
    {
        public AbstractClassPropertyCollectionFactory(IAbstractClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitAbstractClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TAbstractProperty, TExplicitInterfaceProperty>(
            IAbstractClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TAbstractProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new AbstractClassPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new ClassPropertyFactory(property).Value),
                AutoProperties = propertyCollection.AutoProperties.ToList(property => new ClassAutoPropertyFactory(property).Value),
                LambdaProperties = propertyCollection.LambdaProperties.ToList(property => new ClassLambdaPropertyFactory(property).Value),
                AbstractProperties = propertyCollection.AbstractProperties.ToList(property => new AbstractPropertyFactory(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyFactory(property).Value)
            };
        }
    }
}
