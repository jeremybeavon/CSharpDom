namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Properties
{
    public class ClassWithNestedPartialClassWithSealedOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
