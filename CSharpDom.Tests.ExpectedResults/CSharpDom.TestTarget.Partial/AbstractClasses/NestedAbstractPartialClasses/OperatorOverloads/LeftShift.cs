namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithLeftShiftOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
