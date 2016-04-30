namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedClassWithNewAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
