namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.OperatorOverloads
{
    public struct StructWithNestedPartialClassWithLogicalNotOperatorOverload
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
