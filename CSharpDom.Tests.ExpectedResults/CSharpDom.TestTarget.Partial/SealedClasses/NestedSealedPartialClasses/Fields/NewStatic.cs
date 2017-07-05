namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Fields
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNewStaticField : BaseClassWithField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
