﻿using CSharpDom.BaseClasses.Statements;
using CSharpDom.CodeGeneration.Tree.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public abstract class ReadOnlyCatchStatement : AbstractCatchStatement<ReadOnlyTypeReference, ReadOnlyStatement>
    {
        private readonly IReadOnlyList<ReadOnlyStatement> statements;
        private readonly ReadOnlyTypeReference type;
        private readonly string variableName;

        public ReadOnlyCatchStatement(CatchStatement catchStatement)
        {
            statements = ReadOnlyStatement.Create(catchStatement.Statements);
            type = new ReadOnlyTypeReference(catchStatement.Type);
            variableName = catchStatement.Name;
        }

        public override IReadOnlyList<ReadOnlyStatement> Statements
        {
            get { return statements; }
        }

        public override ReadOnlyTypeReference Type
        {
            get { return type; }
        }

        public override string VariableName
        {
            get { return variableName; }
        }
    }
}
