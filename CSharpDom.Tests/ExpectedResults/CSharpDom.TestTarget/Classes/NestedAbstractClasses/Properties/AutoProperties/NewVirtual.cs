namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties.AutoProperties
{
    public class ClassWithNestedAbstractClassWithNewVirtualAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
