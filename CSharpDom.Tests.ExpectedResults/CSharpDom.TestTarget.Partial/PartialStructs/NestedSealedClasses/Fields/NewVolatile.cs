namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Fields
{
    public partial struct PartialStructWithNestedSealedClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
