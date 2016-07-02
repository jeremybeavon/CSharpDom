namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.OperatorOverloads
{
    public static class StaticClassWithNestedAbstractClassWithRightShiftOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
