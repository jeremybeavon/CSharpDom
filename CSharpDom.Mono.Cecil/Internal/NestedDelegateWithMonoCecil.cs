using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class NestedDelegateWithMonoCecil :
        AbstractNestedDelegate<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            DelegateParameterWithMonoCecil>,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly Type type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithMonoCecil returnType;
        private readonly Lazy<Parameters<DelegateParameterWithMonoCecil>> parameters;

        internal NestedDelegateWithMonoCecil(ITypeWithMonoCecil declaringType, Type type)
        {
            this.declaringType = declaringType;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(type));
            MethodInfo method = type.GetMethod("Invoke");
            returnType = TypeReferenceWithMonoCecilFactory.CreateReference(method.ReturnType);
            parameters = new Lazy<Parameters<DelegateParameterWithMonoCecil>>(
                () => new Parameters<DelegateParameterWithMonoCecil>(method, parameter => new DelegateParameterWithMonoCecil(parameter)));
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
            get { return type.Name; }
        }

        public override IReadOnlyList<DelegateParameterWithMonoCecil> Parameters
        {
            get { return parameters.Value.ParametersWithMonoCecil; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return returnType; }
        }

        public Type Type
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
