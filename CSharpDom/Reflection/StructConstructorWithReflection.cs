using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructConstructorWithReflection :
        AbstractStructConstructor<
            AttributeWithReflection,
            ITypeWithReflection,
            ConstructorParameterWithReflection,
            ILMethodBodyWithReflectionEmit>,
        IHasConstructorInfo
    {
        private readonly ConstructorWithReflection constructor;

        internal StructConstructorWithReflection(ITypeWithReflection declaringType, ConstructorInfo constructor)
        {
            this.constructor = new ConstructorWithReflection(declaringType, constructor);
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

        public override IReadOnlyList<ConstructorParameterWithReflection> Parameters
        {
            get { return constructor.Parameters; }
        }
        
        public override StructMemberVisibilityModifier Visibility
        {
            get { return constructor.ConstructorInfo.StructVisibility(); }
        }
    }
}
