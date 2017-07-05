namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Fields
{
    public struct StructWithNestedSealedPartialClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
