namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Properties
{
    public class ClassWithNestedPartialClassWithOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
