using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructMethodCollection :
        IStructMethodCollection<StructMethod, ExplicitInterfaceMethod>
    {
        public StructMethodCollection()
        {
            Methods = new List<StructMethod>();
            ExplicitInterfaceMethods = new List<ExplicitInterfaceMethod>();
        }

        public int Count
        {
            get { return ExplicitInterfaceMethods.Count + Methods.Count; }
        }

        public List<StructMethod> Methods { get; set; }

        public List<ExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }
        
        IReadOnlyCollection<ExplicitInterfaceMethod> IHasExplicitInterfaceMethods<ExplicitInterfaceMethod>.ExplicitInterfaceMethods
        {
            get { return ExplicitInterfaceMethods; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructMethodCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructMethodCollectionChildren(this, visitor);
        }

        public IEnumerator<StructMethod> GetEnumerator()
        {
            return Methods.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
