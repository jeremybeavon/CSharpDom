using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassPropertyCollection :
        IClassPropertyCollection<ClassProperty, ExplicitInterfaceProperty>
    {
        public ClassPropertyCollection()
        {
            Properties = new List<ClassProperty>();
            ExplicitInterfaceProperties = new List<ExplicitInterfaceProperty>();
        }

        public List<ClassProperty> Properties { get; set; }
        
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
            visitor.VisitClassPropertyCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassPropertyCollectionChildren(this, visitor);
        }

        public IEnumerator<ClassProperty> GetEnumerator()
        {
            return Properties.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
