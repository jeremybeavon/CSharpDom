using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableNestedStaticClassMethodCollection<TMethod> :
        AbstractGenericVisitableObject,
        INestedStaticClassMethodCollection<TMethod>
        where TMethod : IStaticClassMethod
    {
        public virtual int Count
        {
            get { return Methods.Count; }
        }

        public abstract ICollection<TMethod> Methods { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedStaticClassMethodCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedStaticClassMethodCollectionChildren(this, visitor);
        }

        public IEnumerator<TMethod> GetEnumerator()
        {
            return Methods.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
