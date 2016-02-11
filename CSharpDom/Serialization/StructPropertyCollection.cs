using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructPropertyCollection :
        IStructPropertyCollection<StructProperty, ExplicitInterfaceProperty>
    {
        public StructPropertyCollection()
        {
            Properties = new List<StructProperty>();
            ExplicitInterfaceProperties = new List<ExplicitInterfaceProperty>();
        }

        public List<StructProperty> Properties { get; set; }
        
        public int Count
        {
            get { return Properties.Count + ExplicitInterfaceProperties.Count; }
        }

        public List<ExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }
        
        IReadOnlyCollection<ExplicitInterfaceProperty> IHasExplicitInterfaceProperties<ExplicitInterfaceProperty>.ExplicitInterfaceProperties
        {
            get { return ExplicitInterfaceProperties; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructPropertyCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructPropertyCollectionChildren(this, visitor);
        }

        public IEnumerator<StructProperty> GetEnumerator()
        {
            return Properties.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
