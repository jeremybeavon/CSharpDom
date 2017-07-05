namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithLogicalNotOperatorOverload
    {
        public abstract partial class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
