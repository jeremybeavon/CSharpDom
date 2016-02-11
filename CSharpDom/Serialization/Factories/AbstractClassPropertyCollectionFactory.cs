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

        public override void VisitAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty>(
            IAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new AbstractClassPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new ClassPropertyFactory(property).Value),
                AbstractProperties = propertyCollection.AbstractProperties.ToList(property => new AbstractPropertyFactory(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyFactory(property).Value)
            };
        }
    }
}
