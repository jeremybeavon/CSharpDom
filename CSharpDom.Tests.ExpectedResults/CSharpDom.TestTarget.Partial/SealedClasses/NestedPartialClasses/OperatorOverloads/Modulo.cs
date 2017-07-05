namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedPartialClassWithModuloOperatorOverload
    {
        public partial class Class
        {
            public static Class operator %(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
