﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AsyncVoidStructMethod :
        IAsyncVoidStructMethod<AttributeGroup, IStructType, GenericParameterDeclaration, MethodParameter, MethodBody>
    {
        public AsyncVoidStructMethod()
        {
            Attributes = new List<AttributeGroup>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Parameters = new List<MethodParameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IStructType DeclaringType
        {
            get { return null; }
        }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }
        
        public string Name { get; set; }

        public List<MethodParameter> Parameters { get; set; }
        
        public StructMemberVisibilityModifier Visibility { get; set; }

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
            visitor.VisitAsyncVoidStructMethod(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAsyncVoidStructMethodChildren(this, visitor);
        }
    }
}
