using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CSharpDom.Reflection
{
    public sealed class ParameterWithReflection :
        AbstractParameter<AttributeWithReflection, ITypeReferenceWithReflection>,
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
        private readonly ITypeReferenceWithReflection parameterType;

        internal ParameterWithReflection(ParameterInfo parameter)
        {
            this.parameter = parameter;
            attributes = new Lazy<Attributes>(() => new Attributes(parameter, excludedAttributeTypes));
            parameterType = TypeReferenceWithReflectionFactory.CreateReference(parameter.ParameterType);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override string Name
        {
            get { return parameter.Name; }
        }

        public override ITypeReferenceWithReflection ParameterType
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
            visitor.VisitParameterWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
