namespace CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties
{
    public class ClassWithNestedClassWithNewStaticAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
