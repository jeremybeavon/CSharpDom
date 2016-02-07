using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassNestedEnum :
        AbstractClassNestedEnum<AttributeGroupNotSupported, IClassType, ReadOnlyEnumField>
    {
        private readonly ClassNestedEnum nestedEnum;
        private readonly IReadOnlyList<ReadOnlyEnumField> enumMembers;

        public ReadOnlyClassNestedEnum(ClassNestedEnum nestedEnum)
        {
            this.nestedEnum = nestedEnum;
            enumMembers = nestedEnum.Fields.ToArray(field => new ReadOnlyEnumField(field, true));
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IClassType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyList<ReadOnlyEnumField> EnumMembers
        {
            get { return enumMembers; }
        }

        public override string Name
        {
            get { return nestedEnum.Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedEnum.Visibility; }
        }

        public override EnumBaseType BaseType
        {
            get { return nestedEnum.BaseType; }
        }
    }
}
