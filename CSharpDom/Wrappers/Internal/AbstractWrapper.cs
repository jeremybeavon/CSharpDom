using CSharpDom.BaseClasses;
using System.Threading.Tasks;

namespace CSharpDom.Wrappers.Internal
{
    public abstract class AbstractWrapper : AbstractGenericVisitor
    {
        public static readonly Task EmptyTask = Task.FromResult<object>(null);
        private readonly object input;

        protected AbstractWrapper(object input)
        {
            this.input = input;
        }

        public sealed override int GetHashCode()
        {
            return input == null ? 0 : input.GetHashCode();
        }

        public sealed override bool Equals(object obj)
        {
            return input != null && input.Equals(obj);
        }

        public sealed override string ToString()
        {
            return input?.ToString();
        }
    }
}
