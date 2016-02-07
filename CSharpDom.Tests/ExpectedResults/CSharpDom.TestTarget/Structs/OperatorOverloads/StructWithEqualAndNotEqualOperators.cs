namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithEqualAndNotEqualOperators
    {
        public static bool operator ==(StructWithEqualAndNotEqualOperators parameter1, StructWithEqualAndNotEqualOperators parameter2)
        {
            return default(bool);
        }

        public static bool operator !=(StructWithEqualAndNotEqualOperators parameter1, StructWithEqualAndNotEqualOperators parameter2)
        {
            return default(bool);
        }
    }
}
