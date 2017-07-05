namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Properties
{
    public class ClassWithNestedAbstractPartialClassWithVirtualProperty
    {
        public abstract partial class Class
        {
            public virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
