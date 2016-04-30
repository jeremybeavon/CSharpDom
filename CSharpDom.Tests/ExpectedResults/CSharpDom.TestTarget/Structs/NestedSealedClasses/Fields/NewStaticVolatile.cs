namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields
{
    public struct StructWithNestedSealedClassWithNewStaticVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
