namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Properties
{
    public class ClassWithNestedPartialClassWithNewStaticProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
