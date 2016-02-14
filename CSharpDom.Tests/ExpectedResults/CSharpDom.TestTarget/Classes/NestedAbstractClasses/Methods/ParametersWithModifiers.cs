﻿namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Methods
{
    public class ClassWithNestedAbstractClassWithMethodWithParametersWithModifiers
    {
        public abstract class Class
        {
            public void Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
