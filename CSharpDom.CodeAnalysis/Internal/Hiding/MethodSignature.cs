using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal.Hiding
{
    internal sealed class MethodSignature :
        AbstractMethod<
            AttributeGroupNotSupported,
            IType,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ParameterSignature,
            EmptyMethodBody>
    {
        private AssemblyWithCodeAnalysis assembly;
        private readonly string name;
        private readonly IReadOnlyList<ParameterSignature> parameters;

        public MethodSignature(AssemblyWithCodeAnalysis assembly, MethodDefinition method)
        {
            this.assembly = assembly;
            name = method.Name;
            parameters = method.Parameters.ToArray(parameter => new ParameterSignature(assembly, parameter));
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

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return new GenericParameterDeclarationWithCodeAnalysis[0]; }
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

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return ReturnTypeSignature.GetReturnType(assembly); }
        }
    }
}
