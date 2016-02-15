﻿using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using CSharpDom.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class AsyncVoidStructMethodWithReflection :
        AbstractAsyncVoidStructMethod<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            MethodParameterWithReflection,
            ILMethodBodyWithReflectionEmit>
    {
        private readonly MethodWithReflection method;
        private readonly IInternalTypeWithReflection declaringType;

        internal AsyncVoidStructMethodWithReflection(IInternalTypeWithReflection declaringType, MethodInfo method)
        {
            this.method = new MethodWithReflection(declaringType, method);
            this.declaringType = declaringType;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return method.Attributes; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return method.Body; }
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

        public override StructMemberVisibilityModifier Visibility
        {
            get { return method.MethodInfo.StructVisibility(); }
        }
    }
}
