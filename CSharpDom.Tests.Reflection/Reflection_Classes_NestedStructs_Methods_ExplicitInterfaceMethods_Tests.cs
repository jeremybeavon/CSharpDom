using CSharpDom.TestTarget.Classes.NestedStructs.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceMethodWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
