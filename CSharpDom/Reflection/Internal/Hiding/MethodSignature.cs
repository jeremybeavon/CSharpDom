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
            ParameterWithReflection,
            EmptyMethodBody>
    {
        private readonly IReadOnlyList<GenericParameterDeclarationWithReflection> genericParameters;
        private readonly string name;
        private readonly IReadOnlyList<ParameterWithReflection> parameters;
        private readonly ITypeReferenceWithReflection returnType;

        public MethodSignature(MethodInfo method)
        {
            genericParameters = new GenericParameterDeclarations(method).GenericParameterDeclarationsWithReflection;
            name = method.Name;
            parameters = new Parameters(method).ParametersWithReflection;
            returnType = TypeReferenceWithReflectionFactory.CreateReference(method.ReturnType);
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
            get { return genericParameters; }
        }

        public override bool IsAsync
        {
            get { return false; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return parameters; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return returnType; }
        }
    }
}
