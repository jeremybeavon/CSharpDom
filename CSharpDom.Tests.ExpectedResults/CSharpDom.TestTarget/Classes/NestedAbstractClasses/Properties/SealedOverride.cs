namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties
{
    public class ClassWithNestedAbstractClassWithSealedOverrideProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
