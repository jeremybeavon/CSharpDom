using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal.Hiding
{
    internal sealed class MethodSignature :
        AbstractMethod<
            AttributeGroupNotSupported,
            IType,
            GenericParameterDeclarationWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            ParameterSignature,
            EmptyMethodBody>
    {
        private readonly string name;
        private readonly IReadOnlyList<ParameterSignature> parameters;

        public MethodSignature(MethodInfo method)
        {
            name = method.Name;
            parameters = method.GetParameters().ToArray(parameter => new ParameterSignature(parameter));
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override EmptyMethodBody Body
        {
            get { return EmptyMethodBody.Default; }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return new GenericParameterDeclarationWithMonoCecil[0]; }
        }

        public override bool IsAsync
        {
            get { return false; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override IReadOnlyList<ParameterSignature> Parameters
        {
            get { return parameters; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return ReturnTypeSignature.Default; }
        }
    }
}
