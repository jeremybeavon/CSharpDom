namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedClassWithNewStaticAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
