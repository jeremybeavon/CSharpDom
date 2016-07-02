namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.OperatorOverloads
{
    public static class StaticClassWithNestedSealedClassWithRightShiftOperatorOverload
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
