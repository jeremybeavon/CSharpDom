namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Fields
{
    public sealed class SealedClassWithNestedSealedClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
