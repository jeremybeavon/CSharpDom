using System;
using CSharpDom.Common;

namespace CSharpDom.NotSupported
{
    public class VisitableNotSupported<TVisitor> :
        IVisitable<TVisitor>,
        IHasClassMemberVisibilityModifier,
        IHasStructMemberVisibilityModifier
    {
        public ClassMemberVisibilityModifier Visibility
        {
            get { throw new NotSupportedException(); }
        }

        StructMemberVisibilityModifier IHasStructMemberVisibilityModifier.Visibility
        {
            get { throw new NotSupportedException(); }
        }

        public void Accept(TVisitor visitor)
        {
        }

        public void AcceptChildren(TVisitor visitor)
        {
        }
    }
}
