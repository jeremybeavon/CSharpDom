﻿namespace CSharpDom.TestTarget.Classes.Properties
{
    public class ClassWithNewProperty : BaseClassWithProperty
    {
        public new string Property
        {
            get { return default(string); }
            set { }
        }
    }
}
