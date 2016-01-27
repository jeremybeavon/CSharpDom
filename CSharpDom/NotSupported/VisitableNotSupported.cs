using System;

namespace CSharpDom.NotSupported
{
    public class VisitableNotSupported<TVisitor> : IVisitable<TVisitor>
    {
        public void Accept(TVisitor visitor)
        {
        }

        public void AcceptChildren(TVisitor visitor)
        {
        }
    }
}
