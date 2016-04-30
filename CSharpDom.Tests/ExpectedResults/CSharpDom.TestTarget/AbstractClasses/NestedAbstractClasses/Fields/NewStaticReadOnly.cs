namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Fields
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewStaticReadOnlyField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
