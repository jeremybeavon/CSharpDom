using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassMethodCollection :
        ISealedClassMethodCollection<SealedClassMethod, ProtectedOverrideMethod, ExplicitInterfaceMethod>
    {
        public SealedClassMethodCollection()
        {
            ProtectedOverrideMethods = new List<ProtectedOverrideMethod>();
            Methods = new List<SealedClassMethod>();
            ExplicitInterfaceMethods = new List<ExplicitInterfaceMethod>();
        }

        public List<ProtectedOverrideMethod> ProtectedOverrideMethods { get; set; }

        public int Count
        {
            get { return ProtectedOverrideMethods.Count + ExplicitInterfaceMethods.Count + Methods.Count; }
        }

        public List<SealedClassMethod> Methods { get; set; }

        public List<ExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }

        IReadOnlyCollection<ProtectedOverrideMethod> IHasProtectedOverrideMethods<ProtectedOverrideMethod>.ProtectedOverrideMethods
        {
            get { return ProtectedOverrideMethods; }
        }

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
