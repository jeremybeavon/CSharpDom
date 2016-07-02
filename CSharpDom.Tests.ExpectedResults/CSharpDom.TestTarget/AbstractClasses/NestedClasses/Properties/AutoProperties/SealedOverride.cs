namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
