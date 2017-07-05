namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods
{
    public struct StructWithNestedPartialClassWithSealedOverrideMethod
    {
        public class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
