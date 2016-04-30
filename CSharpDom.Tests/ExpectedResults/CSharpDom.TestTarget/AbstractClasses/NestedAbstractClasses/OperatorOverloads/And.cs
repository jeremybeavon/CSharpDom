namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedAbstractClassWithAndOperatorOverload
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
