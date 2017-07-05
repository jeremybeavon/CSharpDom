namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithLessThanAndGreaterThanOperatorOverloads
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
