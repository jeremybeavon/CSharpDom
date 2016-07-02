namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedAbstractClassWithLogicalNotOperatorOverload
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
