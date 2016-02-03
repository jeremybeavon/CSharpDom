using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentForStatement
    {
        IFluentExpression Do(Block block);

        IFluentExpression Do(Action statement);
    }
}
