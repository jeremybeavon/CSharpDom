using CSharpDom.TestTarget.Structs.NestedStructs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticMethod));
        }
    }
}
