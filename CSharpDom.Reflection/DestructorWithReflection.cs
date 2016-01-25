using CSharpDom.BaseClasses;
using System.Reflection;
using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection
{
    public sealed class DestructorWithReflection : AbstractDestructor<AttributeWithReflection, ClassWithReflection>
    {


        internal DestructorWithReflection(ClassWithReflection declaringType, MethodInfo method)
        {
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ClassWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
