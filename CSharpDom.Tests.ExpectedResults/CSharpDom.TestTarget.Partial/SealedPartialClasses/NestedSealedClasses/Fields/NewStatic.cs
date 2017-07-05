namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Fields
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNewStaticField : BaseClassWithField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
