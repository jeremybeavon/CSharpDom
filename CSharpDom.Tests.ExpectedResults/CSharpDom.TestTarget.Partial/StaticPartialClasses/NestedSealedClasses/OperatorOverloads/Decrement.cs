namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedSealedClassWithDecrementOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator --(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
