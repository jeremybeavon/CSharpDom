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
            TestStruct(typeof(StructWithNestedStructWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith1GenericParameterUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith2GenericParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticMethod));
        }
    }
}
