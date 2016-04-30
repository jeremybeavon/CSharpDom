namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Fields
{
    public sealed class SealedClassWithNestedAbstractClassWithNewStaticReadOnlyField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
