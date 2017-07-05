namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithDivideOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator /(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
