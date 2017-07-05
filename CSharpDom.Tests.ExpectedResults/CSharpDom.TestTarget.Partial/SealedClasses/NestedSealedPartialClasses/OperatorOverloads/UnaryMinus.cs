namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedSealedPartialClassWithUnaryMinusOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator -(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
