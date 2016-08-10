using CSharpDom.TestTarget.Structs.NestedStructs.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceMethodWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceMethodWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
