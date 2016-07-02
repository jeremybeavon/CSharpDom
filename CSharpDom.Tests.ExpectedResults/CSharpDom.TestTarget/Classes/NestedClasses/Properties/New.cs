namespace CSharpDom.TestTarget.Classes.NestedClasses.Properties
{
    public class ClassWithNestedClassWithNewProperty
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
