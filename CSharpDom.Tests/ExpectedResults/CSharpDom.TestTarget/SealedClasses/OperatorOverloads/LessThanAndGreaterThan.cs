namespace CSharpDom.TestTarget.SealedClasses.OperatorOverloads
{
    public sealed class SealedClassWithLessThanAndGreaterThanOperatorOverloads
    {
        public static bool operator <(SealedClassWithLessThanAndGreaterThanOperatorOverloads parameter1, SealedClassWithLessThanAndGreaterThanOperatorOverloads parameter2)
        {
            return default(bool);
        }

        public static bool operator >(SealedClassWithLessThanAndGreaterThanOperatorOverloads parameter1, SealedClassWithLessThanAndGreaterThanOperatorOverloads parameter2)
        {
            return default(bool);
        }
    }
}
