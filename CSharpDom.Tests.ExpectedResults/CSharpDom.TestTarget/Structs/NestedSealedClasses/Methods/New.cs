namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods
{
    public struct StructWithNestedSealedClassWithNewMethod
    {
        public sealed class Class : BaseClassWithMethod
        {
            public new void Method()
            {
            }
        }
    }
}
