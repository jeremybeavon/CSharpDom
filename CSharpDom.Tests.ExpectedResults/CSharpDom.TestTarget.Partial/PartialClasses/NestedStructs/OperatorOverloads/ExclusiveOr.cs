namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.OperatorOverloads
{
    public partial class PartialClassWithNestedStructWithExclusiveOrOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator ^(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
