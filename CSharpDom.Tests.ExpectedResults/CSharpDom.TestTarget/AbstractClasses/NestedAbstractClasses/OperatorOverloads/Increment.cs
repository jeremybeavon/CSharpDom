namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedAbstractClassWithIncrementOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator ++(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
