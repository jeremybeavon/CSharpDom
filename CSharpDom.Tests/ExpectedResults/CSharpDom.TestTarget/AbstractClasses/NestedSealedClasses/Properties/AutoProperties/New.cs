namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedSealedClassWithNewAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
