namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields
{
    public class ClassWithNestedSealedClassWithNewField
    {
        public sealed class Class : BaseClassWithField
        {
            public new int Field;
        }
    }
}
