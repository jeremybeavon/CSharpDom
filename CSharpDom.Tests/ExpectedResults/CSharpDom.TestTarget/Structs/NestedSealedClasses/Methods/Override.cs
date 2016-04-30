namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods
{
    public struct StructWithNestedSealedClassWithOverrideMethod
    {
        public sealed class Class : BaseClassWithMethod
        {
            public override void Method()
            {
            }
        }
    }
}
