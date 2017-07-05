namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Fields
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNewStaticField : BaseClassWithField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
