namespace CSharpDom.TestTarget.SealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithEqualAndNotEqualOperatorOverloads
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
