namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties
{
    public sealed class SealedClassWithNestedAbstractClassWithPrivateProperty
    {
        public abstract class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
