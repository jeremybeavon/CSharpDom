namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.OperatorOverloads
{
    public static class StaticClassWithNestedSealedClassWithPlusOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator +(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
