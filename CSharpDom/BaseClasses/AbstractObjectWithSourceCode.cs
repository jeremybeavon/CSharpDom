using System.Text;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractObjectWithSourceCode
    {
        protected abstract string ToSourceCodeText();

        public override string ToString()
        {
            return new StringBuilder().AppendLine(GetType().FullName + ":").Append(ToSourceCodeText()).ToString();
        }
    }
}
