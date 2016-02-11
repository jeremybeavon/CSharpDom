using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AbstractClassPropertyCollection :
        IAbstractClassPropertyCollection<ClassProperty, AbstractProperty, ExplicitInterfaceProperty>
    {
        public AbstractClassPropertyCollection()
        {
            Properties = new List<ClassProperty>();
            AbstractProperties = new List<AbstractProperty>();
            ExplicitInterfaceProperties = new List<ExplicitInterfaceProperty>();
        }

        public List<ClassProperty> Properties { get; set; }

        public List<AbstractProperty> AbstractProperties { get; set; }

        public int Count
        {
            get { return Properties.Count + AbstractProperties.Count + ExplicitInterfaceProperties.Count; }
        }

        public List<ExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }

        IReadOnlyCollection<AbstractProperty> IHasAbstractProperties<AbstractProperty>.AbstractProperties
        {
            get { return AbstractProperties; }
        }

        IReadOnlyCollection<ExplicitInterfaceProperty> IHasExplicitInterfaceProperties<ExplicitInterfaceProperty>.ExplicitInterfaceProperties
        {
            get { return ExplicitInterfaceProperties; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassPropertyCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractClassPropertyCollectionChildren(this, visitor);
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
