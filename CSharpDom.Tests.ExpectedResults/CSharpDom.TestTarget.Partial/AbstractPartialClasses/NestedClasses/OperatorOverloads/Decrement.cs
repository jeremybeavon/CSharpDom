namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedClassWithDecrementOperatorOverload
    {
        public class Class
        {
            public static Class operator --(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
