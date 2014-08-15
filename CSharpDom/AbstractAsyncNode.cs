using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom
{
    internal abstract class AbstractAsyncNode
    {
        public abstract Task AcceptAsync(NodeVisitor visitor);
    }
}
