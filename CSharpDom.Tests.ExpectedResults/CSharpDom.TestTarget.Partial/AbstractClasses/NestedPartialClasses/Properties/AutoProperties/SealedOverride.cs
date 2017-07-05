namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedPartialClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
