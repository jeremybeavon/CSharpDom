namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Fields
{
    public struct StructWithNestedSealedPartialClassWithNewStaticField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
