using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Editable
{
    public class EditableMethodBody<TStatement> : IMethodBody<TStatement>
    {
        public virtual IReadOnlyList<TStatement> Statements { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethodBody(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
