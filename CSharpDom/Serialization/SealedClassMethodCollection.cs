using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassMethodCollection :
        ISealedClassMethodCollection<SealedClassMethod, ExplicitInterfaceMethod>
    {
        public SealedClassMethodCollection()
        {
            Methods = new List<SealedClassMethod>();
            ExplicitInterfaceMethods = new List<ExplicitInterfaceMethod>();
        }
        
        public int Count
        {
            get { return ExplicitInterfaceMethods.Count + Methods.Count; }
        }

        public List<SealedClassMethod> Methods { get; set; }

        public List<ExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }
        
        IReadOnlyCollection<ExplicitInterfaceMethod> IHasExplicitInterfaceMethods<ExplicitInterfaceMethod>.ExplicitInterfaceMethods
        {
            get { return ExplicitInterfaceMethods; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassMethodCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassMethodCollectionChildren(this, visitor);
        }

        public IEnumerator<SealedClassMethod> GetEnumerator()
        {
            return Methods.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
