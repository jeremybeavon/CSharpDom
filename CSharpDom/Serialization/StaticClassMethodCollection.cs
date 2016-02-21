using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassMethodCollection : IStaticClassMethodCollection<StaticClassMethod, ExtensionMethod>
    {
        public StaticClassMethodCollection()
        {
            Methods = new List<StaticClassMethod>();
            ExtensionMethods = new List<ExtensionMethod>();
        }

        public int Count
        {
            get { return Methods.Count + ExtensionMethods.Count; }
        }

        public List<StaticClassMethod> Methods { get; set; }

        public List<ExtensionMethod> ExtensionMethods { get; set; }

        IReadOnlyCollection<ExtensionMethod> IHasExtensionMethods<ExtensionMethod>.ExtensionMethods
        {
            get { return ExtensionMethods; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassMethodCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassMethodCollectionChildren(this, visitor);
        }

        public IEnumerator<StaticClassMethod> GetEnumerator()
        {
            return Methods.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
