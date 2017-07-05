namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.OperatorOverloads
{
    public static class StaticClassWithNestedPartialClassWithLogicalNotOperatorOverload
    {
        public partial class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
