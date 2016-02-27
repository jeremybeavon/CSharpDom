using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class DelegateWithMonoCecil :
        AbstractDelegate<
            NamespaceWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AttributeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            DelegateParameterWithMonoCecil>,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithMonoCecil assembly;
        private readonly NamespaceWithMonoCecil @namespace;
        private readonly Type type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithMonoCecil returnType;
        private readonly Lazy<Parameters<DelegateParameterWithMonoCecil>> parameters;

        internal DelegateWithMonoCecil(AssemblyWithMonoCecil assembly, NamespaceWithMonoCecil @namespace, Type type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
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

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithMonoCecil; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public override NamespaceWithMonoCecil Namespace
        {
            get { return @namespace; }
        }

        public override IReadOnlyList<DelegateParameterWithMonoCecil> Parameters
        {
            get { return parameters.Value.ParametersWithMonoCecil; }
        }

        public override AssemblyWithMonoCecil Project
        {
            get { return assembly; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return returnType; }
        }

        public override AssemblyWithMonoCecil Solution
        {
            get { return assembly; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }

        public Type Type
        {
            get { return type; }
        }

        public override AssemblyWithMonoCecil Document
        {
            get { return assembly; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDelegateWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
