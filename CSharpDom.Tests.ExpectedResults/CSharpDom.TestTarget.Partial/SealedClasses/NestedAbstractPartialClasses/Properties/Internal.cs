namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithInternalProperty
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
