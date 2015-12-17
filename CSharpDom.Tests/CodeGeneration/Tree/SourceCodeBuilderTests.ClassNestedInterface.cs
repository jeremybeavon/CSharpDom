using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassNestedInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClassNestedInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public interface ITestClassNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalClassNestedInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    internal interface ITestClassNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedInternalClassNestedInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected internal interface ITestClassNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedClassNestedInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected interface ITestClassNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPrivateClassNestedInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    private interface ITestClassNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith1GenericParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith2GenericParameters()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    GenericParameters =
                                    {
                                        new GenericParameter("TKey"),
                                        new GenericParameter("TValue")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<TKey, TValue>
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWithClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : class
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWithStructGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : struct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWithEmptyConstructorGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWithBaseClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : BaseClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith1ClassNestedInterfaceGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith2ClassNestedInterfaceGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith1GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<TParent, TChild>
        where TChild : TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith2GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<TGrandparent, TParent, TChild>
        where TChild : TGrandparent, TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWithClassAndClassNestedInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : class, ITestInterface, new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith2GenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<TKey, TValue>
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestClassNestedInterfaceWithInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Interfaces =
                                    {
                                        new InterfaceReference("ITestInterface")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith2ClassNestedInterfaces()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Interfaces =
                                    {
                                        new InterfaceReference("ITestInterface"),
                                        new InterfaceReference("ITestInterface2")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialClassNestedInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes = new CodeGenerationCollection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new CodeGenerationCollection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    IsPartial = true
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    partial interface ITestClassNestedInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
