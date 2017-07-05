namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithLogicalNotOperatorOverload
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
