namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties
{
    public class ClassWithNestedSealedClassWithInternalProperty
    {
        public sealed class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
