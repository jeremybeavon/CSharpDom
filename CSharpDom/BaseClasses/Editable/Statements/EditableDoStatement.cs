﻿using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableDoStatement<TExpression, TStatement> :
        EditableStatement,
        IEditableDoStatement<TExpression, TStatement>
        where TExpression : IEditableExpression
        where TStatement : IEditableStatement
    {
        public abstract TExpression Condition { get; set; }

        public abstract TStatement Statement { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitDoStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitDoStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitDoStatementChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
