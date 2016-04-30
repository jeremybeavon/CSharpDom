namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedClassWithSealedOverrideProperty
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
