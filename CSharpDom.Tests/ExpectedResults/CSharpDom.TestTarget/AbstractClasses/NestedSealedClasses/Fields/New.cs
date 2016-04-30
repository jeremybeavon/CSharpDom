namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Fields
{
    public abstract class AbstractClassWithNestedSealedClassWithNewField
    {
        public sealed class Class : BaseClassWithField
        {
            public new int Field;
        }
    }
}
