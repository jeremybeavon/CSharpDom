namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.OperatorOverloads
{
    public static class StaticClassWithNestedSealedClassWithIncrementOperatorOverload
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
