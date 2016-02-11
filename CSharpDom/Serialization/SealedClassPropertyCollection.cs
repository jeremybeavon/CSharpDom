using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassPropertyCollection :
        ISealedClassPropertyCollection<SealedClassProperty, ProtectedOverrideProperty, ExplicitInterfaceProperty>
    {
        public SealedClassPropertyCollection()
        {
            Properties = new List<SealedClassProperty>();
            ProtectedOverrideProperties = new List<ProtectedOverrideProperty>();
            ExplicitInterfaceProperties = new List<ExplicitInterfaceProperty>();
        }

        public List<SealedClassProperty> Properties { get; set; }

        public List<ProtectedOverrideProperty> ProtectedOverrideProperties { get; set; }

        public int Count
        {
            get { return Properties.Count + ProtectedOverrideProperties.Count + ExplicitInterfaceProperties.Count; }
        }

        public List<ExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }

        IReadOnlyCollection<ProtectedOverrideProperty> IHasProtectedOverrideProperties<ProtectedOverrideProperty>.ProtectedOverrideProperties
        {
            get { return ProtectedOverrideProperties; }
        }

        IReadOnlyCollection<ExplicitInterfaceProperty> IHasExplicitInterfaceProperties<ExplicitInterfaceProperty>.ExplicitInterfaceProperties
        {
            get { return ExplicitInterfaceProperties; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassPropertyCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassPropertyCollectionChildren(this, visitor);
        }

        public IEnumerator<SealedClassProperty> GetEnumerator()
        {
            return Properties.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
