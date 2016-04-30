namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields
{
    public struct StructWithNestedSealedClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
