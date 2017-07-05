namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.OperatorOverloads
{
    public struct StructWithNestedPartialClassWithLeftShiftOperatorOverload
    {
        public partial class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
