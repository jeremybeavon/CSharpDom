namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedSealedClassWithLeftShiftOperatorOverload
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
