namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.OperatorOverloads
{
    public static class StaticClassWithNestedAbstractClassWithLogicalNotOperatorOverload
    {
        public abstract class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
