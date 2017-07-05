namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.OperatorOverloads
{
    public static class StaticClassWithNestedPartialClassWithMultiplyOperatorOverload
    {
        public partial class Class
        {
            public static Class operator *(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
