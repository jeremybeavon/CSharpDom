namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.OperatorOverloads
{
    public static class StaticClassWithNestedClassWithUnaryMinusOperatorOverload
    {
        public class Class
        {
            public static Class operator -(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
