namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Properties
{
    public class ClassWithNestedAbstractPartialClassWithInternalProperty
    {
        public abstract partial class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
