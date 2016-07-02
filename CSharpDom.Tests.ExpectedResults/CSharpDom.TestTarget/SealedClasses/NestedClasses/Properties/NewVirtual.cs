namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties
{
    public sealed class SealedClassWithNestedClassWithNewVirtualProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
