using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class StaticClassPropertyCollectionWithMonoCecil :
        IReadOnlyCollection<StaticClassPropertyWithMonoCecil>,
        IPropertyCollection
    {
        private readonly Lazy<IReadOnlyCollection<StaticClassPropertyWithMonoCecil>> properties;

        public StaticClassPropertyCollectionWithMonoCecil(StaticTypeWithMonoCecil typeWithMonoCecil)
        {
            properties = new Lazy<IReadOnlyCollection<StaticClassPropertyWithMonoCecil>>(
                () => typeWithMonoCecil.PropertyCollection.Properties.PropertiesWithMonoCecil);
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

        public IEnumerator<StaticClassPropertyWithMonoCecil> GetEnumerator()
        {
            return properties.Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
