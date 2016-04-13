﻿using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ExplicitInterfaceMethodWithMonoCecil :
        AbstractExplicitInterfaceMethod<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            MethodParameterWithMonoCecil,
            ILMethodBodyWithMonoCecilCil>
    {
        private readonly MethodWithMonoCecil method;
        private readonly InterfaceReferenceWithMonoCecil explicitInterface;

        internal ExplicitInterfaceMethodWithMonoCecil(ITypeWithMonoCecil declaringType, TypeDefinition interfaceType, MethodDefinition method)
        {
            this.method = new MethodWithMonoCecil(declaringType, method);
            explicitInterface = new InterfaceReferenceWithMonoCecil(declaringType.Assembly, interfaceType);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return method.Attributes; }
        }

        public override ILMethodBodyWithMonoCecilCil Body
        {
            get { return method.Body; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return method.DeclaringType; }
        }

        public override InterfaceReferenceWithMonoCecil ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return method.GenericParameters; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }

        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithMonoCecil> Parameters
        {
            get { return method.Parameters; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return method.ReturnType; }
        }
    }
}