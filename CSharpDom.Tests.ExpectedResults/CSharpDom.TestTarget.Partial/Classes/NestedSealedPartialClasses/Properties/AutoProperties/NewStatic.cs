namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Properties.AutoProperties
{
    public class ClassWithNestedSealedPartialClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
