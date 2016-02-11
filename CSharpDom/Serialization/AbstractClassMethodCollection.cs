using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AbstractClassMethodCollection :
        IAbstractClassMethodCollection<ClassMethod, AbstractMethod, ExplicitInterfaceMethod>
    {
        public AbstractClassMethodCollection()
        {
            AbstractMethods = new List<AbstractMethod>();
            Methods = new List<ClassMethod>();
            ExplicitInterfaceMethods = new List<ExplicitInterfaceMethod>();
        }

        public List<AbstractMethod> AbstractMethods { get; set; }

        public int Count
        {
            get { return AbstractMethods.Count + ExplicitInterfaceMethods.Count + Methods.Count; }
        }

        public List<ClassMethod> Methods { get; set; }

        public List<ExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }

        IReadOnlyCollection<AbstractMethod> IHasAbstractMethods<AbstractMethod>.AbstractMethods
        {
            get { return AbstractMethods; }
        }

        IReadOnlyCollection<ExplicitInterfaceMethod> IHasExplicitInterfaceMethods<ExplicitInterfaceMethod>.ExplicitInterfaceMethods
        {
            get { return ExplicitInterfaceMethods; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassMethodCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractClassMethodCollectionChildren(this, visitor);
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
