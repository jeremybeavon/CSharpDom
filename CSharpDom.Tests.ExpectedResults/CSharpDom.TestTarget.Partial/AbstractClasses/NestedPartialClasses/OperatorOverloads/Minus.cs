namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedPartialClassWithMinusOperatorOverload
    {
        public partial class Class
        {
            public static Class operator -(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
