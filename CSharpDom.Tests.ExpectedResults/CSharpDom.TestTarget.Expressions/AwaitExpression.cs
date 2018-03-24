using System.Threading.Tasks;

namespace CSharpDom.TestTarget.Expressions
{
    public sealed class AwaitExpression
    {
        public async Task TestAwait(Task task)
        {
            await task;
        }
    }
}
