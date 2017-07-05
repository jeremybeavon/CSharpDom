namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.OperatorOverloads
{
    public partial class PartialClassWithNestedStructWithIncrementOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator ++(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
