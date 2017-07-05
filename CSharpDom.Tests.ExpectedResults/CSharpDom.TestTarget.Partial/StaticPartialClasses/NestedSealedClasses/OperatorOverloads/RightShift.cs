namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedSealedClassWithRightShiftOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
