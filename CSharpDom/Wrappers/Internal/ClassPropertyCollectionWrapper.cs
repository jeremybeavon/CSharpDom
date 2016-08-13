using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class ClassPropertyCollectionWrapper : AbstractWrapper<IClassPropertyCollection>, IClassPropertyCollectionWrapper
    {
        private Func<int> count;
        private Func<IReadOnlyCollection<IExplicitInterfacePropertyWrapper>> explicitInterfaceProperties;
        private Func<IEnumerator<IClassPropertyWrapper>> properties;

        public ClassPropertyCollectionWrapper(IClassPropertyCollection propertyCollection)
            : base(propertyCollection)
        {
        }

        public int Count
        {
            get { return count(); }
        }

        public IReadOnlyCollection<IExplicitInterfacePropertyWrapper> ExplicitInterfaceProperties
        {
            get { return explicitInterfaceProperties(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassPropertyCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassPropertyCollectionChildren(this, visitor);
        }

        public IEnumerator<IClassPropertyWrapper> GetEnumerator()
        {
            return properties();
        }

        public override void VisitClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            IClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            count = () => propertyCollection.Count;
            explicitInterfaceProperties = () => new ReadOnlyCollectionWrapper<TExplicitInterfaceProperty, IExplicitInterfacePropertyWrapper>(
                propertyCollection.ExplicitInterfaceProperties,
                input => new ExplicitInterfacePropertyWrapper(input));
            properties = () => propertyCollection.Select(input => new ClassPropertyWrapper(input)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
