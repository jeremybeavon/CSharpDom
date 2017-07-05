namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithAndOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator &(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
