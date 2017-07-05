namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public class ClassWithNestedAbstractPartialClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
