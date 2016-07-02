namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Fields
{
    public abstract class AbstractClassWithNestedClassWithNewStaticReadOnlyField
    {
        public class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
