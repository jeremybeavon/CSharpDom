using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassPropertyCollection :
        ISealedClassPropertyCollection<
            SealedClassProperty,
            SealedClassAutoProperty,
            SealedClassLambdaProperty,
            ExplicitInterfaceProperty>
    {
        public SealedClassPropertyCollection()
        {
            Properties = new List<SealedClassProperty>();
            AutoProperties = new List<SealedClassAutoProperty>();
            LambdaProperties = new List<SealedClassLambdaProperty>();
            ExplicitInterfaceProperties = new List<ExplicitInterfaceProperty>();
        }

        public List<SealedClassProperty> Properties { get; set; }
        
        public int Count
        {
            get { return Properties.Count + ExplicitInterfaceProperties.Count; }
        }

        public List<SealedClassAutoProperty> AutoProperties { get; set; }

        public List<SealedClassLambdaProperty> LambdaProperties { get; set; }

        public List<ExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }
        
        IReadOnlyCollection<ExplicitInterfaceProperty> IHasExplicitInterfaceProperties<ExplicitInterfaceProperty>.ExplicitInterfaceProperties
        {
            get { return ExplicitInterfaceProperties; }
        }

        IReadOnlyCollection<SealedClassAutoProperty> IHasAutoProperties<SealedClassAutoProperty>.AutoProperties => AutoProperties;

        IReadOnlyCollection<SealedClassLambdaProperty> IHasLambdaProperties<SealedClassLambdaProperty>.LambdaProperties => LambdaProperties;

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
