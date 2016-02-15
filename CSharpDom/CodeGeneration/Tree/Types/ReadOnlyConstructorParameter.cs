using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyConstructorParameter : AbstractConstructorParameter<AttributeGroupNotSupported, ReadOnlyTypeReference>
    {
        private readonly MethodParameter parameter;
        private readonly ReadOnlyTypeReference parameterType;

        public ReadOnlyConstructorParameter(MethodParameter parameter)
        {
            this.parameter = parameter;
            parameterType = new ReadOnlyTypeReference(parameter.Type);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ParameterModifier Modifier
        {
            get { return parameter.Modifier; }
        }

        public override string Name
        {
            get { return parameter.Name; }
        }

        public override ReadOnlyTypeReference ParameterType
        {
            get { return parameterType; }
        }

        public static IReadOnlyList<ReadOnlyConstructorParameter> Create(IEnumerable<MethodParameter> parameters)
        {
            return parameters.ToArray(parameter => new ReadOnlyConstructorParameter(parameter));
        }
    }
}
