using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.BaseClasses;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class NestedDelegateWithMonoCecil :
        AbstractNestedDelegate<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            DelegateParameterWithMonoCecil>,
        IHasTypeDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly TypeDefinition type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithMonoCecil returnType;
        private readonly Lazy<Parameters<DelegateParameterWithMonoCecil>> parameters;

        internal NestedDelegateWithMonoCecil(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            this.type = type;
            AssemblyWithMonoCecil assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, type));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(assembly, type));
            MethodDefinition invokeMethod = type.Methods.First(method => method.Name == "Invoke");
            returnType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, invokeMethod.ReturnType, invokeMethod);
            parameters = new Lazy<Parameters<DelegateParameterWithMonoCecil>>(
                () => new Parameters<DelegateParameterWithMonoCecil>(assembly, invokeMethod, parameter => new DelegateParameterWithMonoCecil(parameter)));
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

        public override string Name
        {
            get { return type.Name(); }
        }

        public override IReadOnlyList<DelegateParameterWithMonoCecil> Parameters
        {
            get { return parameters.Value.ParametersWithMonoCecil; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return returnType; }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedDelegateWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
