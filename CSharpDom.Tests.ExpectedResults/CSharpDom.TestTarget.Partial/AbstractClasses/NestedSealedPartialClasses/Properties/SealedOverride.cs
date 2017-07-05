namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithSealedOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
