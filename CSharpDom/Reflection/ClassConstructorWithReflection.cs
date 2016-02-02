using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassConstructorWithReflection :
        AbstractClassConstructor<
            AttributeWithReflection,
            ITypeWithReflection,
            ParameterWithReflection,
            ILMethodBodyWithReflectionEmit>,
        IHasConstructorInfo
    {
        private readonly ConstructorWithReflection constructor;

        internal ClassConstructorWithReflection(ConstructorWithReflection constructor)
        {
            this.constructor = constructor;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return constructor.Attributes; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return constructor.Body; }
        }

        public ConstructorInfo ConstructorInfo
        {
            get { return constructor.ConstructorInfo; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return constructor.DeclaringType; }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return constructor.Parameters; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return constructor.ConstructorInfo.Visibility(); }
        }
    }
}
