namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Fields
{
    public sealed class SealedClassWithNestedSealedClassWithNewStaticVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
