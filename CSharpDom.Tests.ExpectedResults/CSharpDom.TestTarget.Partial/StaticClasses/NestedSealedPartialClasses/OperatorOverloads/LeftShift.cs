namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.OperatorOverloads
{
    public static class StaticClassWithNestedSealedPartialClassWithLeftShiftOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
