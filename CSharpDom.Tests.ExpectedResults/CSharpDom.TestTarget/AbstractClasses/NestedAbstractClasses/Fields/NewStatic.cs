namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Fields
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewStaticField : BaseClassWithField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
