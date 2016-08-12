namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithUnaryMinusOperatorOverload
    {
        public static StructWithUnaryMinusOperatorOverload operator -(StructWithUnaryMinusOperatorOverload parameter1)
        {
            return default(StructWithUnaryMinusOperatorOverload);
        }
    }
}
