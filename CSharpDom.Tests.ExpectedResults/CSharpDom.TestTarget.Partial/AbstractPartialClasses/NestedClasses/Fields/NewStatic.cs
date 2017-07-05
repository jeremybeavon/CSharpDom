namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Fields
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNewStaticField : BaseClassWithField
    {
        public class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
