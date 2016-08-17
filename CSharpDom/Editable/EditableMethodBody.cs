using CSharpDom.Common;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableMethodBody<TStatement> : IMethodBody<TStatement>
    {
        public virtual IList<TStatement> Statements { get; set; }

        IReadOnlyList<TStatement> IMethodBody<TStatement>.Statements
        {
            get { return new ReadOnlyCollection<TStatement>(Statements); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethodBody(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
