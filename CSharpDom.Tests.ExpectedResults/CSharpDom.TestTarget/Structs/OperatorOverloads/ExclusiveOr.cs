namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithExclusiveOrOperatorOverload
    {
        public static StructWithExclusiveOrOperatorOverload operator ^(StructWithExclusiveOrOperatorOverload parameter1, StructWithExclusiveOrOperatorOverload parameter2)
        {
            return default(StructWithExclusiveOrOperatorOverload);
        }
    }
}
