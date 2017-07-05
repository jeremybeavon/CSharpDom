namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Fields
{
    public class ClassWithNestedPartialClassWithNewStaticField : BaseClassWithField
    {
        public class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
