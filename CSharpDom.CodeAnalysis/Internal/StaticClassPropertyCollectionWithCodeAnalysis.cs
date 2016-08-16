using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class StaticClassPropertyCollectionWithCodeAnalysis :
        IReadOnlyCollection<StaticClassPropertyWithCodeAnalysis>,
        IPropertyCollection
    {
        private readonly Lazy<IReadOnlyCollection<StaticClassPropertyWithCodeAnalysis>> properties;

        public StaticClassPropertyCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            properties = new Lazy<IReadOnlyCollection<StaticClassPropertyWithCodeAnalysis>>(
                () => typeWithCodeAnalysis.PropertyCollection.Properties.PropertiesWithCodeAnalysis);
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

        public IEnumerator<StaticClassPropertyWithCodeAnalysis> GetEnumerator()
        {
            return properties.Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
