namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedClassWithLeftShiftOperatorOverload
    {
        public class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
