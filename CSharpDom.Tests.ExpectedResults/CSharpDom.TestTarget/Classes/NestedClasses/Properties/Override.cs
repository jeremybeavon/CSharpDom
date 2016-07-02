namespace CSharpDom.TestTarget.Classes.NestedClasses.Properties
{
    public class ClassWithNestedClassWithOverrideProperty
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
