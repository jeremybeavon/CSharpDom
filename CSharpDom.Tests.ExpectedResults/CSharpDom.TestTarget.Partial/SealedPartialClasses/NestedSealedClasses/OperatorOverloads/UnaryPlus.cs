namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithUnaryPlusOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator +(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
