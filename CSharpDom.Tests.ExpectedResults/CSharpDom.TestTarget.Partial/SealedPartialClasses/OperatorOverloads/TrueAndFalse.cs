namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithTrueAndFalseOperatorOverloads
    {
        public static bool operator true(SealedClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }

        public static bool operator false(SealedClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }
    }
}
