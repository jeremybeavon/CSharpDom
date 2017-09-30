using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SealedClassProperty
    {
        private EmptyClassPropertyAccessors emptyAccessors;
        private ClassAccessor getAccessor;
        private ClassAccessor setAccessor;

        public SealedClassProperty(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            emptyAccessors = new EmptyClassPropertyAccessors();
            Visibility = ClassMemberVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public TypeReference Type { get; set; }

        public EmptyClassPropertyAccessors EmptyAccessors
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

        public ClassAccessor GetAccessor
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

        public ClassAccessor SetAccessor
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
