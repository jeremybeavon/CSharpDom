using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
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
            ILMethodBodyWithMonoCecilEmit>,
        IHasMethodInfo
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithMonoCecil returnType;
        private readonly Lazy<Parameters<MethodParameterWithMonoCecil>> parameters;
        private readonly Lazy<ILMethodBodyWithMonoCecilEmit> body;

        internal MethodWithMonoCecil(ITypeWithMonoCecil declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(method));
            returnType = TypeReferenceWithMonoCecilFactory.CreateReference(method.ReturnType);
            parameters = new Lazy<Parameters<MethodParameterWithMonoCecil>>(
                () => new Parameters<MethodParameterWithMonoCecil>(method, parameter => new MethodParameterWithMonoCecil(parameter)));
            body = new Lazy<ILMethodBodyWithMonoCecilEmit>(() => new ILMethodBodyWithMonoCecilEmit(method));
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
        
        public MethodInfo MethodInfo
        {
            get { return method; }
        }

        public override string Name
        {
            get { return method.Name(); }
        }

        public override IReadOnlyList<MethodParameterWithMonoCecil> Parameters
        {
            get { return parameters.Value.ParametersWithMonoCecil; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return returnType; }
        }
        
        public override ILMethodBodyWithMonoCecilEmit Body
        {
            get { return body.Value; }
        }

        public override bool IsAsync
        {
            get { return method.IsDefined(typeof(AsyncStateMachineAttribute)); }
        }
    }
}
