using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common.Statements;

namespace CSharpDom.Mono.Cecil.Internal.Hiding
{
    internal sealed class EmptyMethodBody : AbstractMethodBody<IStatement>
    {
        public static readonly EmptyMethodBody Default = new EmptyMethodBody();

        public override IReadOnlyList<IStatement> Statements
        {
            get { return new IStatement[0]; }
        }
    }
}
