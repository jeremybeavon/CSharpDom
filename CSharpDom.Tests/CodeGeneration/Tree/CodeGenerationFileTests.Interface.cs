using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestInterface()
        {
            const string expectedText = @"interface ITestInterface
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicInterface()
        {
            const string expectedText = @"public interface ITestInterface
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
                    {
                        Visibility = TypeVisibilityModifier.Public
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalInterface()
        {
            const string expectedText = @"internal interface ITestInterface
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
                    {
                        Visibility = TypeVisibilityModifier.Internal
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith1GenericParameter()
        {
            const string expectedText = @"interface ITestInterface<T>
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith2GenericParameters()
        {
            const string expectedText = @"interface ITestInterface<TKey, TValue>
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TKey"),
                            new GenericParameter("TValue")
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWithClassGenericParameterConstraint()
        {
            const string expectedText = @"interface ITestInterface<T>
    where T : class
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraint.Class
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWithStructGenericParameterConstraint()
        {
            const string expectedText = @"interface ITestInterface<T>
    where T : struct
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraint.Struct
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"interface ITestInterface<T>
    where T : new()
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"interface ITestInterface<T>
    where T : BaseClass
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"interface ITestInterface<T>
    where T : ITestInterface
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"interface ITestInterface<T>
    where T : ITestInterface, ITestInterface2
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"interface ITestInterface<TParent, TChild>
    where TChild : TParent
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"interface ITestInterface<TGrandparent, TParent, TChild>
    where TChild : TGrandparent, TParent
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"interface ITestInterface<T>
    where T : class, ITestInterface, new()
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameterTypeConstraint.Class,
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                },
                                HasEmptyConstructorConstraint = true
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith2GenericParameterConstraints()
        {
            const string expectedText = @"interface ITestInterface<TKey, TValue>
    where TKey : ITestInterface
    where TValue : TKey
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
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
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestInterfaceWithInterface()
        {
            const string expectedText = @"interface ITestInterface : ITestInterface
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface")
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInterfaceWith2Interfaces()
        {
            const string expectedText = @"interface ITestInterface : ITestInterface, ITestInterface2
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface"),
                            new InterfaceReference("ITestInterface2")
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialInterface()
        {
            const string expectedText = @"partial interface ITestInterface
{
}";             
(new CodeGenerationFile()
            {
                Interfaces =
                {
                    new Interface("ITestInterface")
                    {
                        IsPartial = true
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
    }
}
