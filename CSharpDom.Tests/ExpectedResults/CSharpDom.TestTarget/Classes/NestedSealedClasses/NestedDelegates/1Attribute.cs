namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedDelegates
{
    public class ClassWithNestedSealedClassWithNestedDelegateWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
