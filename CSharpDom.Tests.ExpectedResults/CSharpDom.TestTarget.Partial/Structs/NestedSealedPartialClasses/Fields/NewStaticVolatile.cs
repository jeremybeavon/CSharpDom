namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Fields
{
    public struct StructWithNestedSealedPartialClassWithNewStaticVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
