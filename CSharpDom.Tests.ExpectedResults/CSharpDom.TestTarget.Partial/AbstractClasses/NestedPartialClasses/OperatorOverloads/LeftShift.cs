namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedPartialClassWithLeftShiftOperatorOverload
    {
        public partial class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
