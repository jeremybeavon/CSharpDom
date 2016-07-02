namespace CSharpDom.TestTarget.Classes.NestedClasses.Properties
{
    public class ClassWithNestedClassWithNewStaticProperty
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
