namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods
{
    public struct StructWithNestedSealedClassWithNewStaticMethod
    {
        public sealed class Class : BaseClassWithMethod
        {
            public new static void Method()
            {
            }
        }
    }
}
