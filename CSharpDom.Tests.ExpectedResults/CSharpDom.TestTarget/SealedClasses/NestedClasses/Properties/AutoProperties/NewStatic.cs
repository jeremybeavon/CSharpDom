namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedClassWithNewStaticAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
