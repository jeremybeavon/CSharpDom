using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ParameterWithMonoCecil :
        AbstractParameter<AttributeWithMonoCecil, ITypeReferenceWithMonoCecil>,
        IHasParameterDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private static readonly Type[] excludedAttributeTypes = new Type[]
        {
            typeof(OutAttribute),
            typeof(ParamArrayAttribute)
        };
        private readonly AssemblyWithMonoCecil assembly;
        private readonly ParameterDefinition parameter;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil parameterType;

        internal ParameterWithMonoCecil(AssemblyWithMonoCecil assembly, ParameterDefinition parameter, MemberReference member)
        {
            this.assembly = assembly;
            this.parameter = parameter;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, parameter, excludedAttributeTypes));
            parameterType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, parameter.ParameterType, member);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override string Name
        {
            get { return parameter.Name; }
        }

        public override ITypeReferenceWithMonoCecil ParameterType
        {
            get { return parameterType; }
        }

        public ParameterDefinition ParameterDefinition
        {
            get { return parameter; }
        }

        internal ParameterModifier Modifier
        {
            get
            {
                if (parameter.IsOut)
                {
                    return ParameterModifier.Out;
                }

                if (parameter.ParameterType.IsByReference)
                {
                    return ParameterModifier.Ref;
                }

                if (parameter.IsDefined(assembly, typeof(ParamArrayAttribute)))
                {
                    return ParameterModifier.Params;
                }

                return ParameterModifier.None;
            }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitParameterWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
