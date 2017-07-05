namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithExclusiveOrOperatorOverload
    {
        public static StructWithExclusiveOrOperatorOverload operator ^(StructWithExclusiveOrOperatorOverload parameter1, StructWithExclusiveOrOperatorOverload parameter2)
        {
            return default(StructWithExclusiveOrOperatorOverload);
        }
    }
}
