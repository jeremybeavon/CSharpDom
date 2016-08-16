using CSharpDom.BaseClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class MethodWithCodeAnalysis :
        AbstractMethod<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasMethodDefinition
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly MethodDefinition method;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<Attributes> returnAttributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithCodeAnalysis returnType;
        private readonly Lazy<Parameters<MethodParameterWithCodeAnalysis>> parameters;
        private readonly Lazy<MethodBodyWithCodeAnalysis> body;

        internal MethodWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            this.declaringType = declaringType;
            this.method = method;
            AssemblyWithCodeAnalysis assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
            returnAttributes = new Lazy<Attributes>(() => new Attributes(assembly, method.MethodReturnType));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(assembly, method));
            returnType = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, method.ReturnType, method);
            parameters = new Lazy<Parameters<MethodParameterWithCodeAnalysis>>(
                () => new Parameters<MethodParameterWithCodeAnalysis>(assembly, method, parameter => new MethodParameterWithCodeAnalysis(parameter)));
            body = new Lazy<MethodBodyWithCodeAnalysis>(() => new MethodBodyWithCodeAnalysis(method));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithCodeAnalysis; }
        }
        
        public MethodDefinition MethodDefinition
        {
            get { return method; }
        }

        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithCodeAnalysis> Parameters
        {
            get { return parameters.Value.ParametersWithCodeAnalysis; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return returnType; }
        }
        
        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
        }

        public override bool IsAsync
        {
            get { return method.IsDefined(declaringType.Assembly, typeof(AsyncStateMachineAttribute)); }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return returnAttributes.Value.AttributesWithCodeAnalysis; }
        }
    }
}
