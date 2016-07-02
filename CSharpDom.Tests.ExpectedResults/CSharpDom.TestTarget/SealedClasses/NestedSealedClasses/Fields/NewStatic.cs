namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Fields
{
    public sealed class SealedClassWithNestedSealedClassWithNewStaticField : BaseClassWithField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
