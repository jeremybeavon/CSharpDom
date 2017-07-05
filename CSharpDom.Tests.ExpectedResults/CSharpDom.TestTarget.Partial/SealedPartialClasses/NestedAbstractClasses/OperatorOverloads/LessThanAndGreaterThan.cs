namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads
    {
        public abstract class Class
        {
            public static bool operator <(Class parameter1, Class parameter2)
            {
                return default(bool);
            }

            public static bool operator >(Class parameter1, Class parameter2)
            {
                return default(bool);
            }
        }
    }
}
