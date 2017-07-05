namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.OperatorOverloads
{
    public struct StructWithNestedPartialClassWithIncrementOperatorOverload
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
