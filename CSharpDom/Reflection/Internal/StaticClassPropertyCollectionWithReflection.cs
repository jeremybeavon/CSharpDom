using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class StaticClassPropertyCollectionWithReflection :
        IReadOnlyCollection<StaticClassPropertyWithReflection>,
        IPropertyCollection
    {
        private readonly Lazy<IReadOnlyCollection<StaticClassPropertyWithReflection>> properties;

        public StaticClassPropertyCollectionWithReflection(StaticTypeWithReflection typeWithReflection)
        {
            properties = new Lazy<IReadOnlyCollection<StaticClassPropertyWithReflection>>(
                () => typeWithReflection.PropertyCollection.Properties.PropertiesWithReflection);
        }

        public int Count
        {
            get { return properties.Value.Count; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            GenericVisitor.VisitCollection(this, visitor);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotSupportedException();
        }

        public IEnumerator<StaticClassPropertyWithReflection> GetEnumerator()
        {
            return properties.Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
