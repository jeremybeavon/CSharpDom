namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedStaticClassWithNestedDelegateWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
