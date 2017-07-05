namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithLogicalNotOperatorOverload
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
