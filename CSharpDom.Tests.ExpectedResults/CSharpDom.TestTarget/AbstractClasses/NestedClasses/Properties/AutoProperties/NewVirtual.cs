namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedClassWithNewVirtualAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
