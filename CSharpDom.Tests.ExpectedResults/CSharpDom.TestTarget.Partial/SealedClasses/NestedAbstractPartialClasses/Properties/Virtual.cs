namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithVirtualProperty
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
