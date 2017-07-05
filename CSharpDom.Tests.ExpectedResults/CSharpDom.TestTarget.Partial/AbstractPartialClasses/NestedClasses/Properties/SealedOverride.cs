namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Properties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithSealedOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
