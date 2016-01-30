using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyEnum :
        AbstractEnum<
            NamespaceNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroupNotSupported,
            ReadOnlyEnumField>
    {
        private readonly Enum @enum;
        private readonly IReadOnlyList<ReadOnlyEnumField> enumMembers;

        public ReadOnlyEnum(Enum @enum)
        {
            this.@enum = @enum;
            enumMembers = @enum.Fields.ToArray(field => new ReadOnlyEnumField(field, false));
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IReadOnlyList<ReadOnlyEnumField> EnumMembers
        {
            get { return enumMembers; }
        }

        public override string Name
        {
            get { return @enum.Name; }
        }

        public override NamespaceNotSupported Namespace
        {
            get { return new NamespaceNotSupported(); }
        }

        public override ProjectNotSupported Project
        {
            get { return new ProjectNotSupported(); }
        }

        public override SolutionNotSupported Solution
        {
            get { return new SolutionNotSupported(); }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return @enum.Visibility; }
        }
    }
}
