using CSharpDom.TestTarget.Classes.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWithParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
