﻿namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructProperty
    {
        private EmptyStructPropertyAccessors emptyAccessors;
        private StructPropertyAccessor getAccessor;
        private StructPropertyAccessor setAccessor;

        public StructProperty(string name)
        {
            Name = name;
            emptyAccessors = new EmptyStructPropertyAccessors();
        }

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

        public StructPropertyAccessor GetAccessor
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

        public StructPropertyAccessor SetAccessor
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
