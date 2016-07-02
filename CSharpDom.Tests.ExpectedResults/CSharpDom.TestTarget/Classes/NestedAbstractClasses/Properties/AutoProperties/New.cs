namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties.AutoProperties
{
    public class ClassWithNestedAbstractClassWithNewAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
