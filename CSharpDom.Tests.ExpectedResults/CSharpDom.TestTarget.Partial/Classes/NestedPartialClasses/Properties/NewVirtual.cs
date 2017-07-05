namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Properties
{
    public class ClassWithNestedPartialClassWithNewVirtualProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
