namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedClassWithNestedDelegateWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
