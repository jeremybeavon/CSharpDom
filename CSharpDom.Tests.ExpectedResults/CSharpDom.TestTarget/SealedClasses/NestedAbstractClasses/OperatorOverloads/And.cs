namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedAbstractClassWithAndOperatorOverload
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
