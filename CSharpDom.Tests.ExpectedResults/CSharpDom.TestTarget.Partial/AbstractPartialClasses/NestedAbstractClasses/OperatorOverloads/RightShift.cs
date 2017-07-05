namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithRightShiftOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
