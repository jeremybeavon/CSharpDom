namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties
{
    public class ClassWithNestedSealedClassWithNewAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
