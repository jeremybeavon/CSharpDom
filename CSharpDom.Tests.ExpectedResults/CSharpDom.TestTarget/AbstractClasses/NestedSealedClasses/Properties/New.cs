namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties
{
    public abstract class AbstractClassWithNestedSealedClassWithNewProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
