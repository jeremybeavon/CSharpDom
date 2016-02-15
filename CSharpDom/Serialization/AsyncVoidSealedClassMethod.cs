﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AsyncVoidSealedClassMethod :
        IAsyncVoidSealedClassMethod<AttributeGroup, ISealedType, GenericParameterDeclaration, MethodParameter, MethodBody>
    {
        public AsyncVoidSealedClassMethod()
        {
            Attributes = new List<AttributeGroup>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Parameters = new List<MethodParameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public ISealedType DeclaringType
        {
            get { return null; }
        }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public SealedClassMemberInheritanceModifier InheritanceModifier { get; set; }
        
        public string Name { get; set; }

        public List<MethodParameter> Parameters { get; set; }
        
        public ClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<GenericParameterDeclaration> IHasGenericParameters<GenericParameterDeclaration>.GenericParameters
        {
            get { return GenericParameters; }
        }

        IReadOnlyList<MethodParameter> IHasParameters<MethodParameter>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAsyncVoidSealedClassMethod(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAsyncVoidSealedClassMethodChildren(this, visitor);
        }
    }
}
