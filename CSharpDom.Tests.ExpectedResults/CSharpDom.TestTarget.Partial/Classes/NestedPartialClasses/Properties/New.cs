namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Properties
{
    public class ClassWithNestedPartialClassWithNewProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
