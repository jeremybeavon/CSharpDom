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
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassExplicitInterfaceMethodWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
