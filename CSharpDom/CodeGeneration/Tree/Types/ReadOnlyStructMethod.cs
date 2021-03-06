﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructMethod :
        AbstractStructMethod<
            AttributeGroupNotSupported,
            IStructType,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyTypeReference,
            ReadOnlyMethodParameter,
            ReadOnlyMethodBody>
    {
        private readonly StructMethod method;
        private readonly ReadOnlyMethodBody body;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyList<ReadOnlyMethodParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyStructMethod(StructMethod method)
        {
            this.method = method;
            body = new ReadOnlyMethodBody(method.Body);
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(method.GenericParameters);
            parameters = ReadOnlyMethodParameter.Create(method.Parameters);
            returnType = new ReadOnlyTypeReference(method.ReturnType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyMethodBody Body
        {
            get { return body; }
        }

        public override IStructType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }
        
        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<ReadOnlyMethodParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyTypeReference ReturnType
        {
            get { return returnType; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return method.Visibility; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> ReturnAttributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override StructMemberInheritanceModifier InheritanceModifier
        {
            get { return method.InheritanceModifier == StructMethodInheritanceModifier.Static ? StructMemberInheritanceModifier.Static : StructMemberInheritanceModifier.None; }
        }
    }
}
