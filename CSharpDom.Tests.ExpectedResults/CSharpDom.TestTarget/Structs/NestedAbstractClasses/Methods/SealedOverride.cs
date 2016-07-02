namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods
{
    public struct StructWithNestedAbstractClassWithSealedOverrideMethod
    {
        public abstract class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
