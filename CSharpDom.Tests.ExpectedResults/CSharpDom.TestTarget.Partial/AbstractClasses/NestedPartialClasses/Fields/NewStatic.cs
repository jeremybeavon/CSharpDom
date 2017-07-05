namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Fields
{
    public abstract class AbstractClassWithNestedPartialClassWithNewStaticField : BaseClassWithField
    {
        public class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
