namespace CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties
{
    public class ClassWithNestedClassWithOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
