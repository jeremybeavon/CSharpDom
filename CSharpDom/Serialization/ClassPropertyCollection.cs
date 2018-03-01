using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassPropertyCollection :
        IClassPropertyCollection<
            ClassProperty,
            ClassAutoProperty,
            ClassLambdaProperty,
            ExplicitInterfaceProperty>
    {
        public ClassPropertyCollection()
        {
            Properties = new List<ClassProperty>();
            AutoProperties = new List<ClassAutoProperty>();
            LambdaProperties = new List<ClassLambdaProperty>();
            ExplicitInterfaceProperties = new List<ExplicitInterfaceProperty>();
        }

        public List<ClassProperty> Properties { get; set; }
        
        public int Count
        {
            get { return Properties.Count + AutoProperties.Count + LambdaProperties.Count + ExplicitInterfaceProperties.Count; }
        }

        public List<ClassAutoProperty> AutoProperties { get; set; }

        public List<ClassLambdaProperty> LambdaProperties { get; set; }

        public List<ExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }
        
        IReadOnlyCollection<ExplicitInterfaceProperty> IHasExplicitInterfaceProperties<ExplicitInterfaceProperty>.ExplicitInterfaceProperties
        {
            get { return ExplicitInterfaceProperties; }
        }

        IReadOnlyCollection<ClassAutoProperty> IHasAutoProperties<ClassAutoProperty>.AutoProperties => AutoProperties;

        IReadOnlyCollection<ClassLambdaProperty> IHasLambdaProperties<ClassLambdaProperty>.LambdaProperties => LambdaProperties;

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
