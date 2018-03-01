using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class ClassPropertyCollectionFactory :
        AbstractFactory<IClassPropertyCollection, ClassPropertyCollection>
    {
        public ClassPropertyCollectionFactory(IClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>(
            IClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new ClassPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new ClassPropertyFactory(property).Value),
                AutoProperties = propertyCollection.AutoProperties.ToList(property => new ClassAutoPropertyFactory(property).Value),
                LambdaProperties = propertyCollection.LambdaProperties.ToList(property => new ClassLambdaPropertyFactory(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyFactory(property).Value)
            };
        }
    }
}
