using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyOperatorParameter : AbstractParameter<AttributeGroupNotSupported, ReadOnlyTypeReference>
    {
        private readonly string name;
        private readonly ReadOnlyTypeReference parameterType;

        public ReadOnlyOperatorParameter(string name, TypeReference parameterType)
        {
            this.name = name;
            this.parameterType = new ReadOnlyTypeReference(parameterType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ParameterModifier Modifier
        {
            get { return ParameterModifier.None; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override ReadOnlyTypeReference ParameterType
        {
            get { return parameterType; }
        }
    }
}
