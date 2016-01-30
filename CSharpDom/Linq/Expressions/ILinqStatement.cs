using CSharpDom.Common.Statements;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.Expressions
{
    public interface ILinqStatement : IStatement
    {
        Expression Statement { get; }
    }
}
