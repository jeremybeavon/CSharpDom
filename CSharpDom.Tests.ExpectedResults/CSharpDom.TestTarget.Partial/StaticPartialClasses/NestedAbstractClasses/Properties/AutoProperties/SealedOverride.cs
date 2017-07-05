namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
