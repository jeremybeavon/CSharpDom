namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties.AutoProperties
{
    public class ClassWithNestedAbstractClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
