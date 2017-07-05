namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.OperatorOverloads
{
    public partial class PartialClassWithNestedStructWithLogicalNotOperatorOverload
    {
        public struct Struct
        {
            public static bool operator !(Struct parameter1)
            {
                return default(bool);
            }
        }
    }
}
