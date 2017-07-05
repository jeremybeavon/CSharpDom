namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.OperatorOverloads
{
    public static class StaticClassWithNestedSealedPartialClassWithUnaryPlusOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator +(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
