﻿using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DelegateReferenceWithCodeAnalysis :
        AbstractDelegateReference<GenericParameterWithCodeAnalysis>,
        ITypeReferenceWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly TypeReference type;
        private readonly Lazy<GenericParameters> genericParameters;

        internal DelegateReferenceWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, TypeReference type)
        {
            this.type = type;
            genericParameters = new Lazy<GenericParameters>(() => new GenericParameters(assembly, type));
        }

        public override IReadOnlyList<GenericParameterWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters.Value.GenericParametersWithCodeAnalysis; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public TypeReference TypeReference
        {
            get { return type; }
        }


        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDelegateReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
