﻿namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassProperty
    {
        private EmptyClassPropertyAccessors emptyAccessors;
        private ClassAccessor getAccessor;
        private ClassAccessor setAccessor;

        public ClassProperty(string name)
        {
            Name = name;
            emptyAccessors = new EmptyClassPropertyAccessors();
        }

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
