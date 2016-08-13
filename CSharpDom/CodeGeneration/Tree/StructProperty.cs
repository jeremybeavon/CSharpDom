using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructProperty
    {
        private EmptyStructPropertyAccessors emptyAccessors;
        private StructAccessor getAccessor;
        private StructAccessor setAccessor;

        public StructProperty(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            emptyAccessors = new EmptyStructPropertyAccessors();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public bool IsStatic { get; set; }

        public TypeReference Type { get; set; }

        public EmptyStructPropertyAccessors EmptyAccessors
        {
            get
            {
                return emptyAccessors;
            }

            set
            {
                emptyAccessors = value;
                if (value != null)
                {
                    getAccessor = null;
                    setAccessor = null;
                }
            }
        }

        public StructAccessor GetAccessor
        {
            get
            {
                return getAccessor;
            }

            set
            {
                getAccessor = value;
                if (value != null)
                {
                    emptyAccessors = null;
                }
            }
        }

        public StructAccessor SetAccessor
        {
            get
            {
                return setAccessor;
            }

            set
            {
                setAccessor = value;
                if (value != null)
                {
                    emptyAccessors = null;
                }
            }
        }
    }
}
