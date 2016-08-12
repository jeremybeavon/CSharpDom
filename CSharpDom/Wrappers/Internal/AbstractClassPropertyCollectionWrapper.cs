using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class AbstractClassPropertyCollectionWrapper :
        AbstractWrapper<IAbstractClassPropertyCollection>
    {
        public AbstractClassPropertyCollectionWrapper(IAbstractClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty>(
            IAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new AbstractClassPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new ClassPropertyWrapper(property).Value),
                AbstractProperties = propertyCollection.AbstractProperties.ToList(property => new AbstractPropertyWrapper(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyWrapper(property).Value)
            };
        }
    }
}
