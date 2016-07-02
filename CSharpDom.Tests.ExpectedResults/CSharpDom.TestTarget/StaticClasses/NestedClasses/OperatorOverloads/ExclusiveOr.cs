namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.OperatorOverloads
{
    public static class StaticClassWithNestedClassWithExclusiveOrOperatorOverload
    {
        public class Class
        {
            public static Class operator ^(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
