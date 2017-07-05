namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Properties.AutoProperties
{
    public static partial class StaticPartialClassWithNestedClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
