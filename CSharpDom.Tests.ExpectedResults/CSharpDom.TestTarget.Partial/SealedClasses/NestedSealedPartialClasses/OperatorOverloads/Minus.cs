namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedSealedPartialClassWithMinusOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator -(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
