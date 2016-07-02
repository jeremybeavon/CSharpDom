namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedSealedClassWithMultiplyOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator *(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
