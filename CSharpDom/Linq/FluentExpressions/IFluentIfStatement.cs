using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.FluentExpressions
{
    public interface IFluentIfStatement
    {
        IFluentElseStatement Then(Block block);

        IFluentElseStatement Then(Action statement);

        IFluentElseStatement Then<T>(T statement);
    }
}
