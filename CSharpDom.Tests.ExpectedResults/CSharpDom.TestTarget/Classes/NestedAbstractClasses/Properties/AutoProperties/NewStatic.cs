namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties.AutoProperties
{
    public class ClassWithNestedAbstractClassWithNewStaticAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
