namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedSealedPartialClassWithLogicalNotOperatorOverload
    {
        public sealed partial class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
