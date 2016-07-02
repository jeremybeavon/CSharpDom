namespace CSharpDom.TestTarget.Structs.NestedClasses.Methods
{
    public struct StructWithNestedClassWithNewVirtualMethod
    {
        public class Class : BaseClassWithMethod
        {
            public new virtual void Method()
            {
            }
        }
    }
}
