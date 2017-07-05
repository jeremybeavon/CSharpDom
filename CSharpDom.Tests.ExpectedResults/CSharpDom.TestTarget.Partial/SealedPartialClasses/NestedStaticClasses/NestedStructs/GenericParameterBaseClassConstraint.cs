namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
