namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties.AutoProperties
{
    public class ClassWithNestedAbstractClassWithOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
