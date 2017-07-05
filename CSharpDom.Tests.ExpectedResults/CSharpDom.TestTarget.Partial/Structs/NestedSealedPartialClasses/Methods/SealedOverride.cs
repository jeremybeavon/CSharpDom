namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Methods
{
    public struct StructWithNestedSealedPartialClassWithSealedOverrideMethod
    {
        public sealed class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
