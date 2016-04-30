namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedClassWithOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
