namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedClassWithNewAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
