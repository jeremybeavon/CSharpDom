namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedSealedClassWithAndOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator &(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
