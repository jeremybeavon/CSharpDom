namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithPrivateProperty
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
