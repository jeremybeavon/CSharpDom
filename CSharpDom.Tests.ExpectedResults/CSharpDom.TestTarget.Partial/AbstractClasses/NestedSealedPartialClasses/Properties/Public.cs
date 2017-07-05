namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithPublicProperty
    {
        public sealed partial class Class
        {
            public string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
