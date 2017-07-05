namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedPartialClassWithDecrementOperatorOverload
    {
        public partial class Class
        {
            public static Class operator --(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
