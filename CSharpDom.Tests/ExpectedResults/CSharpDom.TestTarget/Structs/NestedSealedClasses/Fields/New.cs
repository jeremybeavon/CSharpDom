namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields
{
    public struct StructWithNestedSealedClassWithNewField
    {
        public sealed class Class : BaseClassWithField
        {
            public new int Field;
        }
    }
}
