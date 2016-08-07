using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class MethodWithMonoCecil :
        AbstractMethod<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            MethodParameterWithMonoCecil,
            ILMethodBodyWithMonoCecilCil>,
        IHasMethodDefinition
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly MethodDefinition method;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithMonoCecil returnType;
        private readonly Lazy<Parameters<MethodParameterWithMonoCecil>> parameters;
        private readonly Lazy<ILMethodBodyWithMonoCecilCil> body;

        internal MethodWithMonoCecil(ITypeWithMonoCecil declaringType, MethodDefinition method)
        {
            this.declaringType = declaringType;
            this.method = method;
            AssemblyWithMonoCecil assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(assembly, method));
            returnType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, method.ReturnType, method);
            parameters = new Lazy<Parameters<MethodParameterWithMonoCecil>>(
                () => new Parameters<MethodParameterWithMonoCecil>(assembly, method, parameter => new MethodParameterWithMonoCecil(parameter)));
            body = new Lazy<ILMethodBodyWithMonoCecilCil>(() => new ILMethodBodyWithMonoCecilCil(method));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithMonoCecil; }
        }
        
        public MethodDefinition MethodDefinition
        {
            get { return method; }
        }

        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithMonoCecil> Parameters
        {
            get { return parameters.Value.ParametersWithMonoCecil; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return returnType; }
        }
        
        public override ILMethodBodyWithMonoCecilCil Body
        {
            get { return body.Value; }
        }

        public override bool IsAsync
        {
            get { return method.IsDefined(declaringType.Assembly, typeof(AsyncStateMachineAttribute)); }
        }
    }
}
