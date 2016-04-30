namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedSealedClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
