namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties
{
    public class ClassWithNestedSealedClassWithOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
