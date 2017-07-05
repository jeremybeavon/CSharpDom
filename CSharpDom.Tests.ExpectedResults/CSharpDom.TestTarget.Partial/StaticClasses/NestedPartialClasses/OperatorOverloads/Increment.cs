namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.OperatorOverloads
{
    public static class StaticClassWithNestedPartialClassWithIncrementOperatorOverload
    {
        public partial class Class
        {
            public static Class operator ++(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
