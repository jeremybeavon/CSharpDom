using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Reflection;

namespace CSharpDom.Reflection.Internal.Hiding
{
    internal sealed class MethodSignature :
        AbstractMethod<
            AttributeGroupNotSupported,
            IType,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
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

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return new GenericParameterDeclarationWithReflection[0]; }
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

        public override IReadOnlyCollection<AttributeGroupNotSupported> ReturnAttributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return ReturnTypeSignature.Default; }
        }
    }
}
