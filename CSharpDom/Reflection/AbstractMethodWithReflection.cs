﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class AbstractMethodWithReflection :
        AbstractAbstractMethod<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            MethodParameterWithReflection>
    {
        private readonly MethodWithReflection method;

        internal AbstractMethodWithReflection(ITypeWithReflection declaringType, MethodInfo method)
        {
            this.method = new MethodWithReflection(declaringType, method);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return method.Attributes; }
        }
        
        public override ITypeWithReflection DeclaringType
        {
            get { return method.DeclaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return method.GenericParameters; }
        }
        
        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithReflection> Parameters
        {
            get { return method.Parameters; }
        }

        public override IReadOnlyCollection<AttributeWithReflection> ReturnAttributes
        {
            get { return method.ReturnAttributes; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return method.ReturnType; }
        }

        public override AbstractMemberVisibilityModifier Visibility
        {
            get { return method.MethodInfo.AbstractClassVisibility(); }
        }
    }
}
