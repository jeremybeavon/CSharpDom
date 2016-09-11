using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class FinallyStatementWithCodeAnalysis :
        EditableFinallyStatement<IStatementWithCodeAnalysis>,
        IHasSyntax<FinallyClauseSyntax>
    {
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
    }
}
