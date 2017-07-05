namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Constructors
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithConstructorWithParametersWithModifiers
    {
        public abstract partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
