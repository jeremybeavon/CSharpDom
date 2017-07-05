namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Properties.AutoProperties
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
