namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Fields
{
    public partial struct PartialStructWithWithNestedSealedClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
