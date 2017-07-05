namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedPartialClassWithBitwiseNotOperatorOverload
    {
        public partial class Class
        {
            public static Class operator ~(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
