namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithProtectedProperty
    {
        public abstract partial class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
