namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithPlusOperatorOverload
    {
        public static StructWithPlusOperatorOverload operator +(StructWithPlusOperatorOverload parameter1, StructWithPlusOperatorOverload parameter2)
        {
            return default(StructWithPlusOperatorOverload);
        }
    }
}
