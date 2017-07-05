namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithDecrementOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator --(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
