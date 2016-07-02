namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedSealedClassWithIncrementOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator ++(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
