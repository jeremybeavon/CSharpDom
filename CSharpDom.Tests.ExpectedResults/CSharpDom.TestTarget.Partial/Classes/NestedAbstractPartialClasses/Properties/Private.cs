namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Properties
{
    public class ClassWithNestedAbstractPartialClassWithPrivateProperty
    {
        public abstract partial class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
