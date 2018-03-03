using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AbstractClassPropertyCollection :
        IAbstractClassPropertyCollection<
            ClassProperty,
            ClassAutoProperty,
            ClassLambdaProperty,
            AbstractProperty,
            ExplicitInterfaceProperty>
    {
        public AbstractClassPropertyCollection()
        {
            Properties = new List<ClassProperty>();
            AutoProperties = new List<ClassAutoProperty>();
            LambdaProperties = new List<ClassLambdaProperty>();
            AbstractProperties = new List<AbstractProperty>();
            ExplicitInterfaceProperties = new List<ExplicitInterfaceProperty>();
        }

        public List<ClassProperty> Properties { get; set; }

        public List<AbstractProperty> AbstractProperties { get; set; }

        public List<ClassAutoProperty> AutoProperties { get; set; }

        public List<ClassLambdaProperty> LambdaProperties { get; set; }

        public int Count
        {
            get
            {
                return Properties.Count +
                    AutoProperties.Count +
                    LambdaProperties.Count +
                    AbstractProperties.Count +
                    ExplicitInterfaceProperties.Count;
            }
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

        IReadOnlyCollection<ClassAutoProperty> IHasAutoProperties<ClassAutoProperty>.AutoProperties => AutoProperties;

        IReadOnlyCollection<ClassLambdaProperty> IHasLambdaProperties<ClassLambdaProperty>.LambdaProperties => LambdaProperties;

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
