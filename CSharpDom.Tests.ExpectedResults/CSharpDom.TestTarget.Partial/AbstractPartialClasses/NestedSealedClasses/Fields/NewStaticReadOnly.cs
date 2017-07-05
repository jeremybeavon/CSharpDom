namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Fields
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNewStaticReadOnlyField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
