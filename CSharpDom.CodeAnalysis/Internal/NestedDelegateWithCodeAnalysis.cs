using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.BaseClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class NestedDelegateWithCodeAnalysis :
        AbstractNestedDelegate<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            DelegateParameterWithCodeAnalysis>,
        IHasTypeDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly TypeDefinition type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithCodeAnalysis returnType;
        private readonly Lazy<Parameters<DelegateParameterWithCodeAnalysis>> parameters;

        internal NestedDelegateWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            this.type = type;
            AssemblyWithCodeAnalysis assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, type));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(assembly, type));
            MethodDefinition invokeMethod = type.Methods.First(method => method.Name == "Invoke");
            returnType = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, invokeMethod.ReturnType, invokeMethod);
            parameters = new Lazy<Parameters<DelegateParameterWithCodeAnalysis>>(
                () => new Parameters<DelegateParameterWithCodeAnalysis>(assembly, invokeMethod, parameter => new DelegateParameterWithCodeAnalysis(parameter)));
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

        public override string Name
        {
            get { return type.Name(); }
        }

        public override IReadOnlyList<DelegateParameterWithCodeAnalysis> Parameters
        {
            get { return parameters.Value.ParametersWithCodeAnalysis; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return returnType; }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedDelegateWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
