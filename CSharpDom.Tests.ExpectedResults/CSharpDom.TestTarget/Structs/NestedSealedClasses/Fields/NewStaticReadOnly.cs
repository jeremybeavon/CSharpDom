namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields
{
    public struct StructWithNestedSealedClassWithNewStaticReadOnlyField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
