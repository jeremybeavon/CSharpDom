namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithEqualAndNotEqualOperatorOverloads
    {
        public static bool operator ==(StructWithEqualAndNotEqualOperatorOverloads parameter1, StructWithEqualAndNotEqualOperatorOverloads parameter2)
        {
            return default(bool);
        }

        public static bool operator !=(StructWithEqualAndNotEqualOperatorOverloads parameter1, StructWithEqualAndNotEqualOperatorOverloads parameter2)
        {
            return default(bool);
        }
    }
}
