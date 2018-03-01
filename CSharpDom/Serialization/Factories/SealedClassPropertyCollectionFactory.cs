using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class SealedClassPropertyCollectionFactory :
        AbstractFactory<ISealedClassPropertyCollection, SealedClassPropertyCollection>
    {
        public SealedClassPropertyCollectionFactory(ISealedClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitSealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>(
            ISealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new SealedClassPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new SealedClassPropertyFactory(property).Value),
                AutoProperties = propertyCollection.AutoProperties.ToList(property => new SealedClassAutoPropertyFactory(property).Value),
                LambdaProperties = propertyCollection.LambdaProperties.ToList(property => new SealedClassLambdaPropertyFactory(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyFactory(property).Value)
            };
        }
    }
}
