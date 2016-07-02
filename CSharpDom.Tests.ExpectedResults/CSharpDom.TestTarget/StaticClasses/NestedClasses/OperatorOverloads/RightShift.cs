namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.OperatorOverloads
{
    public static class StaticClassWithNestedClassWithRightShiftOperatorOverload
    {
        public class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
