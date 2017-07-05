namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Methods
{
    public struct StructWithNestedAbstractPartialClassWithSealedOverrideMethod
    {
        public abstract class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
