namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithUnaryPlusOperatorOverload
    {
        public static StructWithUnaryPlusOperatorOverload operator +(StructWithUnaryPlusOperatorOverload parameter1)
        {
            return default(StructWithUnaryPlusOperatorOverload);
        }
    }
}
