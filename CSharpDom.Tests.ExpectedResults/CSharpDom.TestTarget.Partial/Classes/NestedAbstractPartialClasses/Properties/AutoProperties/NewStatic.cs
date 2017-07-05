namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public class ClassWithNestedAbstractPartialClassWithNewStaticAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
