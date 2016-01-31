using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestClassNestedInterface()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClassNestedInterface()
        {
            const string expectedText = @"class TestClass
{
    public interface ITestClassNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalClassNestedInterface()
        {
            const string expectedText = @"class TestClass
{
    internal interface ITestClassNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedInternalClassNestedInterface()
        {
            const string expectedText = @"class TestClass
{
    protected internal interface ITestClassNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestProtectedClassNestedInterface()
        {
            const string expectedText = @"class TestClass
{
    protected interface ITestClassNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPrivateClassNestedInterface()
        {
            const string expectedText = @"class TestClass
{
    private interface ITestClassNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith1GenericParameter()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith2GenericParameters()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<TKey, TValue>
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWithClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : class
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWithStructGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : struct
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWithEmptyConstructorGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWithBaseClassGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : BaseClass
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith1ClassNestedInterfaceGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith2ClassNestedInterfaceGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith1GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<TParent, TChild>
        where TChild : TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith2GenericTypeGenericParameterConstraint()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<TGrandparent, TParent, TChild>
        where TChild : TGrandparent, TParent
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWithClassAndClassNestedInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<T>
        where T : class, ITestInterface, new()
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
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
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith2GenericParameterConstraints()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface<TKey, TValue>
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestClassNestedInterfaceWithInterface()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface : ITestInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassNestedInterfaceWith2ClassNestedInterfaces()
        {
            const string expectedText = @"class TestClass
{
    interface ITestClassNestedInterface : ITestInterface, ITestInterface2
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialClassNestedInterface()
        {
            const string expectedText = @"class TestClass
{
    partial interface ITestClassNestedInterface
    {
    }
}";             
(new CodeGenerationFile()
            {
                Classes = new Collection<Class>()
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            NestedInterfaces = new Collection<ClassNestedInterface>()
                            {
                                new ClassNestedInterface("ITestClassNestedInterface")
                                {
                                    IsPartial = true
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }
    }
}
