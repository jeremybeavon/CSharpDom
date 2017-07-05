namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithEqualAndNotEqualOperatorOverloads
    {
        public static bool operator ==(SealedClassWithEqualAndNotEqualOperatorOverloads parameter1, SealedClassWithEqualAndNotEqualOperatorOverloads parameter2)
        {
            return default(bool);
        }

        public static bool operator !=(SealedClassWithEqualAndNotEqualOperatorOverloads parameter1, SealedClassWithEqualAndNotEqualOperatorOverloads parameter2)
        {
            return default(bool);
        }
    }
}
