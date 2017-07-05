namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Fields
{
    public partial struct PartialStructWithWithNestedSealedClassWithNewStaticReadOnlyField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
