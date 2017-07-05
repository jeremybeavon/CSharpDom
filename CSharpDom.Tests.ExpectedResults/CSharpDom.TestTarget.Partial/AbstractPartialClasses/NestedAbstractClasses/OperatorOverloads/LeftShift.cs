namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithLeftShiftOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
