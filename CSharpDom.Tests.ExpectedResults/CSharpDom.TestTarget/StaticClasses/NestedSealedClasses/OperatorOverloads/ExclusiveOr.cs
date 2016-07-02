namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.OperatorOverloads
{
    public static class StaticClassWithNestedSealedClassWithExclusiveOrOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator ^(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
