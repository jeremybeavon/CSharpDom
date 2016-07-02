namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedClassWithDecrementOperatorOverload
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
