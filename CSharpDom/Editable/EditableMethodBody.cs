﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public abstract class EditableMethodBody<TStatement> : AbstractGenericVisitableObject, IMethodBody<TStatement>
    {
        public abstract IList<TStatement> Statements { get; set; }

        IReadOnlyList<TStatement> IMethodBody<TStatement>.Statements
        {
            get { return new ReadOnlyCollection<TStatement>(Statements); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethodBody(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
