namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Fields
{
    public struct StructWithNestedSealedPartialClassWithNewStaticReadOnlyField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
