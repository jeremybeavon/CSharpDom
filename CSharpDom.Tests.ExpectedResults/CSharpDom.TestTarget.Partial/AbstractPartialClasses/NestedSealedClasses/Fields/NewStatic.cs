namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Fields
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNewStaticField : BaseClassWithField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
