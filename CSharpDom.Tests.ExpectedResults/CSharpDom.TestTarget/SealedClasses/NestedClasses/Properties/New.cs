namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties
{
    public sealed class SealedClassWithNestedClassWithNewProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
