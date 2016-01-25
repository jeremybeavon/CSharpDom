using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class DelegateWithReflection :
        AbstractDelegate<
            NamespaceWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AttributeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            ParameterWithReflection>
    {
        private readonly AssemblyWithReflection assembly;
        private readonly NamespaceWithReflection @namespace;
        private readonly Type type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithReflection returnType;
        private readonly Lazy<Parameters> parameters;

        internal DelegateWithReflection(AssemblyWithReflection assembly, NamespaceWithReflection @namespace, Type type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(type));
            MethodInfo method = type.GetMethod("Invoke");
            returnType = TypeReferenceWithReflectionFactory.CreateReference(method.ReturnType);
            parameters = new Lazy<Parameters>(() => new Parameters(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithReflection; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public override NamespaceWithReflection Namespace
        {
            get { return @namespace; }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return parameters.Value.ParametersWithReflection; }
        }

        public override AssemblyWithReflection Project
        {
            get { return assembly; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return returnType; }
        }

        public override AssemblyWithReflection Solution
        {
            get { return assembly; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }
    }
}
