namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithLogicalNotOperatorOverload
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
