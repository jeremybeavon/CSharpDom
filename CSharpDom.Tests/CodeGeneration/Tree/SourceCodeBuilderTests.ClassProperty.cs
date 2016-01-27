using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassWithProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2Properties()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Type = new TypeReference("string")
                                },
                                new ClassProperty("Property2")
                                {
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    string Property1 { get; set; }

    string Property2 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInternalProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    internal string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedInternalProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected internal string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPrivateProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    private string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicAbstractProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Abstract,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public abstract string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.New,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public new string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewStaticProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.NewStatic,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public new static string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewVirtualProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.NewVirtual,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public new virtual string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicOverrideProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Override,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public override string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicSealedOverrideProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.SealedOverride,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public sealed override string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicStaticProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Static,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public static string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicVirtualProperty()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Properties = new CodeGenerationCollection<ClassProperty>()
                            {
                                new ClassProperty("Property1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Virtual,
                                    Type = new TypeReference("string")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public virtual string Property1 { get; set; }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
