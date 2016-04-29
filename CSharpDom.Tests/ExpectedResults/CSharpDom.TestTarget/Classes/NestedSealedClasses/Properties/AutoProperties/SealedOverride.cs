namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties
{
    public class ClassWithNestedSealedClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
