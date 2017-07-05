namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Properties.AutoProperties
{
    public class ClassWithNestedSealedPartialClassWithNewAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
