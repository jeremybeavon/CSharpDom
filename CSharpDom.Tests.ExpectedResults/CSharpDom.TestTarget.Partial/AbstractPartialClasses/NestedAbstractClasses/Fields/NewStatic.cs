namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Fields
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNewStaticField : BaseClassWithField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
