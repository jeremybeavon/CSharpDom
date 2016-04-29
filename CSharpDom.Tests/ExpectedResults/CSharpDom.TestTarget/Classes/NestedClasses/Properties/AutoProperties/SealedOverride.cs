namespace CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties
{
    public class ClassWithNestedClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
