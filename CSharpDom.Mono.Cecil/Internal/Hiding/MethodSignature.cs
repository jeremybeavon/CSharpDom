using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using Mono.Cecil;

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
        private AssemblyWithMonoCecil assembly;
        private readonly string name;
        private readonly IReadOnlyList<ParameterSignature> parameters;

        public MethodSignature(AssemblyWithMonoCecil assembly, MethodDefinition method)
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
            get { return ReturnTypeSignature.GetReturnType(assembly); }
        }
    }
}
