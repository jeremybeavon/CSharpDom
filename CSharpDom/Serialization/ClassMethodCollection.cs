using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassMethodCollection :
        IClassMethodCollection<ClassMethod, ExplicitInterfaceMethod>
    {
        public ClassMethodCollection()
        {
            Methods = new List<ClassMethod>();
            ExplicitInterfaceMethods = new List<ExplicitInterfaceMethod>();
        }

        public int Count
        {
            get { return ExplicitInterfaceMethods.Count + Methods.Count; }
        }

        public List<ClassMethod> Methods { get; set; }

        public List<ExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }
        
        IReadOnlyCollection<ExplicitInterfaceMethod> IHasExplicitInterfaceMethods<ExplicitInterfaceMethod>.ExplicitInterfaceMethods
        {
            get { return ExplicitInterfaceMethods; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassMethodCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassMethodCollectionChildren(this, visitor);
        }

        public IEnumerator<ClassMethod> GetEnumerator()
        {
            return Methods.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
