namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Fields
{
    public partial struct PartialStructWithWithNestedSealedClassWithNewStaticField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
