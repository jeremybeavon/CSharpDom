namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Fields
{
    public abstract class AbstractClassWithNestedSealedClassWithNewStaticReadOnlyField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
