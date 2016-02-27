using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ParameterWithMonoCecil :
        AbstractParameter<AttributeWithMonoCecil, ITypeReferenceWithMonoCecil>,
        IHasParameterInfo//,
        //IVisitable<IReflectionVisitor>
    {
        private static readonly Type[] excludedAttributeTypes = new Type[]
        {
            typeof(OutAttribute),
            typeof(ParamArrayAttribute)
        };
        private readonly ParameterInfo parameter;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil parameterType;

        internal ParameterWithMonoCecil(ParameterInfo parameter)
        {
            this.parameter = parameter;
            attributes = new Lazy<Attributes>(() => new Attributes(parameter, excludedAttributeTypes));
            parameterType = TypeReferenceWithMonoCecilFactory.CreateReference(parameter.ParameterType);
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

        public ParameterInfo ParameterInfo
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

                if (parameter.ParameterType.IsByRef)
                {
                    return ParameterModifier.Ref;
                }

                if (parameter.IsDefined(typeof(ParamArrayAttribute)))
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
