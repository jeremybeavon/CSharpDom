namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties
{
    public abstract class AbstractClassWithNestedClassWithSealedOverrideProperty
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
