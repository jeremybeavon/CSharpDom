using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class DefaultCaseStatementWithCodeAnalysis :
        EditableDefaultCaseStatement<IStatementWithCodeAnalysis>,
        IHasSyntax<DefaultSwitchLabelSyntax>,
        IInternalStatement
    {
        private readonly Guid internalId;
        private readonly StatementNode<DefaultCaseStatementWithCodeAnalysis, DefaultSwitchLabelSyntax> node;
        private readonly StatementListWrapper<DefaultCaseStatementWithCodeAnalysis, DefaultSwitchLabelSyntax>

        public override IList<IStatementWithCodeAnalysis> Statements
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DefaultSwitchLabelSyntax Syntax
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        Guid IHasId.InternalId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        void IHasParent<IInternalStatement, StatementSyntax>.SetParentNode<TParentNode, TParentSyntax>(TParentNode parent, Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
        {
            throw new NotImplementedException();
        }

        void IHasParent<IInternalStatement, StatementSyntax>.SetParentNode<TParentNode, TParentSyntax>(TParentNode parent, Func<TParentSyntax, StatementSyntax> getChildSyntax, Func<TParentSyntax, StatementSyntax, TParentSyntax> createChildSyntax)
        {
            throw new NotImplementedException();
        }
    }
}
