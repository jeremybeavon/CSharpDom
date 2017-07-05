namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Fields
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNewStaticField : BaseClassWithField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
