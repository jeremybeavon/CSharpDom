namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Methods
{
    public partial struct PartialStructWithWithNestedClassWithSealedOverrideMethod
    {
        public class Class : BaseClassWithMethod
        {
            public sealed override void Method()
            {
            }
        }
    }
}
