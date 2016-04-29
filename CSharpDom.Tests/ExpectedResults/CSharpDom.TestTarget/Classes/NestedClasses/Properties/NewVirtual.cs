namespace CSharpDom.TestTarget.Classes.NestedClasses.Properties
{
    public class ClassWithNestedClassWithNewVirtualProperty
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
