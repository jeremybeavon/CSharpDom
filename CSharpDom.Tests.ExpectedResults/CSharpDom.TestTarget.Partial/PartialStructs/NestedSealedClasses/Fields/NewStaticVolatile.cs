namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Fields
{
    public partial struct PartialStructWithWithNestedSealedClassWithNewStaticVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
