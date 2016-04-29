namespace CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties
{
    public class ClassWithNestedClassWithNewAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
