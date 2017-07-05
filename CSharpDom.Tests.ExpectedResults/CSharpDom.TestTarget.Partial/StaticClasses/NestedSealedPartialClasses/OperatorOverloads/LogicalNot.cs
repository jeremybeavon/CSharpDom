namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.OperatorOverloads
{
    public static class StaticClassWithNestedSealedPartialClassWithLogicalNotOperatorOverload
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
