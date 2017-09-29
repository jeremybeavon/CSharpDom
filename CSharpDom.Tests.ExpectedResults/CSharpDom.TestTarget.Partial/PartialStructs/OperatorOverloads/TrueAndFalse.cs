namespace CSharpDom.TestTarget.Partial.PartialStructs.OperatorOverloads
{
    public partial struct PartialStructWithTrueAndFalseOperatorOverloads
    {
        public static bool operator true(PartialStructWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }

        public static bool operator false(PartialStructWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }
    }
}
