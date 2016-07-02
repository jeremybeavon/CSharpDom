namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedClassWithNewVirtualAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
