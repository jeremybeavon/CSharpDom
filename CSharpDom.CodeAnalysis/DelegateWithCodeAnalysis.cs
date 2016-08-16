using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DelegateWithCodeAnalysis :
        AbstractDelegate<
            NamespaceWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            DelegateParameterWithCodeAnalysis>,
        IHasTypeDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithCodeAnalysis assembly;
        private readonly NamespaceWithCodeAnalysis @namespace;
        private readonly TypeDefinition type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithCodeAnalysis returnType;
        private readonly Lazy<Parameters<DelegateParameterWithCodeAnalysis>> parameters;

        internal DelegateWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, NamespaceWithCodeAnalysis @namespace, TypeDefinition type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
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

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithCodeAnalysis; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return @namespace; }
        }

        public override IReadOnlyList<DelegateParameterWithCodeAnalysis> Parameters
        {
            get { return parameters.Value.ParametersWithCodeAnalysis; }
        }

        public override AssemblyWithCodeAnalysis Project
        {
            get { return assembly; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return returnType; }
        }

        public override AssemblyWithCodeAnalysis Solution
        {
            get { return assembly; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }

        public override AssemblyWithCodeAnalysis Document
        {
            get { return assembly; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDelegateWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
