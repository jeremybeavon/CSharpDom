using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestClassWithIndexer()
        {
            const string expectedText = @"class TestClass
{
    string this[string parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(string)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2Indexers()
        {
            const string expectedText = @"class TestClass
{
    string this[string parameter1]
    {
        set { }
    }

    string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(string)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                },
                                new ClassIndexer()
                                {
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicIndexer()
        {
            const string expectedText = @"class TestClass
{
    public string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInternalIndexer()
        {
            const string expectedText = @"class TestClass
{
    internal string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedInternalIndexer()
        {
            const string expectedText = @"class TestClass
{
    protected internal string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedIndexer()
        {
            const string expectedText = @"class TestClass
{
    protected string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPrivateIndexer()
        {
            const string expectedText = @"class TestClass
{
    private string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        /*[TestMethod]
        public void TestClassWithPublicAbstractIndexer()
        {
            const string expectedText = @"class TestClass
{
    public abstract string this[int parameter1] { set; }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.Abstract,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassPropertyAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        [TestMethod]
        public void TestClassWithPublicNewIndexer()
        {
            const string expectedText = @"class TestClass
{
    public new string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.New,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestClassWithPublicNewVirtualIndexer()
        {
            const string expectedText = @"class TestClass
{
    public new virtual string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.NewVirtual,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicOverrideIndexer()
        {
            const string expectedText = @"class TestClass
{
    public override string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.Override,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicSealedOverrideIndexer()
        {
            const string expectedText = @"class TestClass
{
    public sealed override string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.SealedOverride,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicVirtualIndexer()
        {
            const string expectedText = @"class TestClass
{
    public virtual string this[int parameter1]
    {
        set { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Indexers = new Collection<ClassIndexer>()
                            {
                                new ClassIndexer()
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = IndexerInheritanceModifier.Virtual,
                                    Type = new TypeReference("string"),
                                    Parameters = new Collection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1", new TypeReference(typeof(int)))
                                    },
                                    SetAccessor = new ClassAccessor()
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
    }
}
