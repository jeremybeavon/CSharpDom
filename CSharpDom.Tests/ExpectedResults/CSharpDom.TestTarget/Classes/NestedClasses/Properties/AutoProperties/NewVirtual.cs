namespace CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties
{
    public class ClassWithNestedClassWithNewVirtualAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
