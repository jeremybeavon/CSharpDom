namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Fields
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNewStaticReadOnlyField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
