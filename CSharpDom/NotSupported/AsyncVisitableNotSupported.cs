using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.NotSupported
{
    public class AsyncVisitableNotSupported<TVisitor> : IAsyncVisitable<TVisitor>
    {
        private static readonly Task EmptyTask = new Task(() => { });

        public Task AcceptAsync(TVisitor visitor)
        {
            return EmptyTask;
        }

        public Task AcceptChildrenAsync(TVisitor visitor)
        {
            return EmptyTask;
        }
    }
}
