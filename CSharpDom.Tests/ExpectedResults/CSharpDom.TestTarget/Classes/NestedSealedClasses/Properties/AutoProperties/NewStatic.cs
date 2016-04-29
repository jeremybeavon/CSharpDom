namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties
{
    public class ClassWithNestedSealedClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
