using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Visibility = TypeVisibilityModifier.Public
                    }
                }
            }).Accept(builder);
            const string expectedText = @"public class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Visibility = TypeVisibilityModifier.Internal
                    }
                }
            }).Accept(builder);
            const string expectedText = @"internal class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithBaseClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        BaseClass = new ClassReference("BaseClass")
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass : BaseClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith1GenericParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2GenericParameters()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TKey"),
                            new GenericParameter("TValue")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<TKey, TValue>
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraintModifier.Class
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : class
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithStructGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraintModifier.Struct
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : struct
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithEmptyConstructorGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                HasEmptyConstructorConstraint = true
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : new()
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithBaseClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                BaseClassConstraint = new ClassReference("BaseClass")
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : BaseClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith1InterfaceGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : ITestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2InterfaceGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface"),
                                    new InterfaceReference("ITestInterface2")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : ITestInterface, ITestInterface2
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith1GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TParent"),
                            new GenericParameter("TChild")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TParent")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<TParent, TChild>
    where TChild : TParent
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TGrandparent"),
                            new GenericParameter("TParent"),
                            new GenericParameter("TChild")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TGrandparent"),
                                    new GenericParameterReference("TParent")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<TGrandparent, TParent, TChild>
    where TChild : TGrandparent, TParent
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraintModifier.Class,
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                },
                                HasEmptyConstructorConstraint = true
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : class, ITestInterface, new()
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2GenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TKey")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                }
                            },
                            new GenericParameter("TValue")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TKey")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<TKey, TValue>
    where TKey : ITestInterface
    where TValue : TKey
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestAbstractClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        InheritanceModifier = TypeInheritanceModifier.Abstract
                    }
                }
            }).Accept(builder);
            const string expectedText = @"abstract class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestSealedClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        InheritanceModifier = TypeInheritanceModifier.Sealed
                    }
                }
            }).Accept(builder);
            const string expectedText = @"sealed class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStaticClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        InheritanceModifier = TypeInheritanceModifier.Static
                    }
                }
            }).Accept(builder);
            const string expectedText = @"static class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass : ITestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2Interfaces()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface"),
                            new InterfaceReference("ITestInterface2")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass : ITestInterface, ITestInterface2
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        IsPartial = true
                    }
                }
            }).Accept(builder);
            const string expectedText = @"partial class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
