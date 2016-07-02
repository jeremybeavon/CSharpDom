namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties
{
    public class ClassWithNestedSealedClassWithProtectedProperty
    {
        public sealed class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
