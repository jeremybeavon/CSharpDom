namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticClassProperty
    {
        private EmptyStaticClassPropertyAccessors emptyAccessors;
        private StaticClassAccessor getAccessor;
        private StaticClassAccessor setAccessor;

        public StaticClassProperty(string name)
        {
            Name = name;
            emptyAccessors = new EmptyStaticClassPropertyAccessors();
        }

        public string Name { get; set; }

        public StaticClassMemberVisibilityModifier Visibility { get; set; }
        
        public TypeReference Type { get; set; }

        public EmptyStaticClassPropertyAccessors EmptyAccessors
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

        public StaticClassAccessor GetAccessor
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

        public StaticClassAccessor SetAccessor
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
