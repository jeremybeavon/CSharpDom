namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Fields
{
    public partial struct PartialStructWithNestedSealedClassWithNewStaticField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
