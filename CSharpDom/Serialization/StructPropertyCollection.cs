using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructPropertyCollection :
        IStructPropertyCollection<
            StructProperty,
            StructAutoProperty,
            StructLambdaProperty,
            ExplicitInterfaceProperty>
    {
        public StructPropertyCollection()
        {
            Properties = new List<StructProperty>();
            AutoProperties = new List<StructAutoProperty>();
            LambdaProperties = new List<StructLambdaProperty>();
            ExplicitInterfaceProperties = new List<ExplicitInterfaceProperty>();
        }

        public List<StructProperty> Properties { get; set; }
        
        public int Count
        {
            get { return Properties.Count + AutoProperties.Count + LambdaProperties.Count + ExplicitInterfaceProperties.Count; }
        }

        public List<StructAutoProperty> AutoProperties { get; set; }

        public List<StructLambdaProperty> LambdaProperties { get; set; }

        public List<ExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }
        
        IReadOnlyCollection<ExplicitInterfaceProperty> IHasExplicitInterfaceProperties<ExplicitInterfaceProperty>.ExplicitInterfaceProperties
        {
            get { return ExplicitInterfaceProperties; }
        }

        IReadOnlyCollection<StructAutoProperty> IHasAutoProperties<StructAutoProperty>.AutoProperties => AutoProperties;

        IReadOnlyCollection<StructLambdaProperty> IHasLambdaProperties<StructLambdaProperty>.LambdaProperties => LambdaProperties;

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
