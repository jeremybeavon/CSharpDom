namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.OperatorOverloads
{
    public struct StructWithNestedSealedPartialClassWithModuloOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator %(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
