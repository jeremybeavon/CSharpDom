namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Constructors
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers
    {
        public abstract class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
