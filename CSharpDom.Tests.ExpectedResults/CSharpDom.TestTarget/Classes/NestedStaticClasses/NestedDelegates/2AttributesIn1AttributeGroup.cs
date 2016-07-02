namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedDelegates
{
    public class ClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
