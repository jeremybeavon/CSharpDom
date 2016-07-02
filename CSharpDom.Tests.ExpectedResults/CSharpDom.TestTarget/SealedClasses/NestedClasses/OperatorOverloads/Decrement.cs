namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedClassWithDecrementOperatorOverload
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
