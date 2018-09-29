using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassPropertyCollection :
        IStaticClassPropertyCollection<
            StaticClassProperty,
            StaticClassAutoProperty,
            StaticClassLambdaProperty>
    {
        public StaticClassPropertyCollection()
        {
            Properties = new List<StaticClassProperty>();
            AutoProperties = new List<StaticClassAutoProperty>();
            LambdaProperties = new List<StaticClassLambdaProperty>();
        }

        public List<StaticClassProperty> Properties { get; set; }
        
        public int Count
        {
            get { return Properties.Count + AutoProperties.Count + LambdaProperties.Count; }
        }

        public List<StaticClassAutoProperty> AutoProperties { get; set; }

        public List<StaticClassLambdaProperty> LambdaProperties { get; set; }

        IReadOnlyCollection<StaticClassAutoProperty> IHasAutoProperties<StaticClassAutoProperty>.AutoProperties => AutoProperties;

        IReadOnlyCollection<StaticClassLambdaProperty> IHasLambdaProperties<StaticClassLambdaProperty>.LambdaProperties => LambdaProperties;

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassPropertyCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassPropertyCollectionChildren(this, visitor);
        }

        public IEnumerator<StaticClassProperty> GetEnumerator()
        {
            return Properties.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
