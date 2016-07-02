namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedSealedClassWithLeftShiftOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
