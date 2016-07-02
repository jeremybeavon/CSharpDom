namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedClassWithOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
