namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.OperatorOverloads
{
    public struct StructWithNestedPartialClassWithPlusOperatorOverload
    {
        public partial class Class
        {
            public static Class operator +(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
