using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestClass()
        {
            const string expectedText = @"class TestClass
{
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClass()
        {
            const string expectedText = @"public class TestClass
{
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Visibility = TypeVisibilityModifier.Public
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalClass()
        {
            const string expectedText = @"internal class TestClass
{
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Visibility = TypeVisibilityModifier.Internal
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithBaseClass()
        {
            const string expectedText = @"class TestClass : BaseClass
{
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        BaseClass = new ClassReference("BaseClass")
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith1GenericParameter()
        {
            const string expectedText = @"class TestClass<T>
{
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2GenericParameters()
        {
            const string expectedText = @"class TestClass<TKey, TValue>
{
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass<T>
    where T : class
{
}";             
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
                                TypeConstraint = GenericParameterTypeConstraint.Class
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithStructGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass<T>
    where T : struct
{
}";             
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
                                TypeConstraint = GenericParameterTypeConstraint.Struct
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass<T>
    where T : new()
{
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass<T>
    where T : BaseClass
{
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith1InterfaceGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass<T>
    where T : ITestInterface
{
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2InterfaceGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass<T>
    where T : ITestInterface, ITestInterface2
{
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass<TParent, TChild>
    where TChild : TParent
{
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass<TGrandparent, TParent, TChild>
    where TChild : TGrandparent, TParent
{
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass<T>
    where T : class, ITestInterface, new()
{
}";             
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
        public void TestClassWith2GenericParameterConstraints()
        {
            const string expectedText = @"class TestClass<TKey, TValue>
    where TKey : ITestInterface
    where TValue : TKey
{
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        /*[TestMethod]
        public void TestAbstractClass()
        {
            const string expectedText = @"abstract class TestClass
{
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        InheritanceModifier = TypeInheritanceModifier.Abstract
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestSealedClass()
        {
            const string expectedText = @"sealed class TestClass
{
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        InheritanceModifier = TypeInheritanceModifier.Sealed
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStaticClass()
        {
            const string expectedText = @"static class TestClass
{
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        InheritanceModifier = TypeInheritanceModifier.Static
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/

        [TestMethod]
        public void TestClassWithInterface()
        {
            const string expectedText = @"class TestClass : ITestInterface
{
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2Interfaces()
        {
            const string expectedText = @"class TestClass : ITestInterface, ITestInterface2
{
}";             
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
            }).ToString().Should().Be(expectedText);
        }

        /*[TestMethod]
        public void TestPartialClass()
        {
            const string expectedText = @"partial class TestClass
{
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        IsPartial = true
                    }
                }
            }).ToString().Should().Be(expectedText);
        }*/
    }
}
