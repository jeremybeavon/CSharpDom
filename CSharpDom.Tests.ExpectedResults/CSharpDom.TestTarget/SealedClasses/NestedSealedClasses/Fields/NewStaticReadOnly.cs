namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Fields
{
    public sealed class SealedClassWithNestedSealedClassWithNewStaticReadOnlyField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
