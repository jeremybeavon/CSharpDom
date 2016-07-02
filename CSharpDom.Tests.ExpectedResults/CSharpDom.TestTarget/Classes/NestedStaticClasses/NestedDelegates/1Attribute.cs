namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedDelegates
{
    public class ClassWithNestedStaticClassWithNestedDelegateWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
