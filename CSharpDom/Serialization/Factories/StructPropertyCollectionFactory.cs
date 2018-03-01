using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class StructPropertyCollectionFactory :
        AbstractFactory<IStructPropertyCollection, StructPropertyCollection>
    {
        public StructPropertyCollectionFactory(IStructPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitStructPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>(
            IStructPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new StructPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new StructPropertyFactory(property).Value),
                AutoProperties = propertyCollection.AutoProperties.ToList(property => new StructAutoPropertyFactory(property).Value),
                LambdaProperties = propertyCollection.LambdaProperties.ToList(property => new StructLambdaPropertyFactory(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyFactory(property).Value)
            };
        }
    }
}
