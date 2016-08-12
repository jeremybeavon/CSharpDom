using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class SealedClassPropertyCollectionWrapper :
        AbstractWrapper<ISealedClassPropertyCollection>
    {
        public SealedClassPropertyCollectionWrapper(ISealedClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public override void VisitSealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            ISealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            Value = new SealedClassPropertyCollection()
            {
                Properties = propertyCollection.ToList(property => new SealedClassPropertyWrapper(property).Value),
                ExplicitInterfaceProperties = propertyCollection.ExplicitInterfaceProperties.ToList(property => new ExplicitInterfacePropertyWrapper(property).Value)
            };
        }
    }
}
