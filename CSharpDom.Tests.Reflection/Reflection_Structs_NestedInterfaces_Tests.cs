using CSharpDom.TestTarget.Structs.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedInterfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedInterfaceWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWith1GenericParameterUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWith2GenericParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithInternalNestedInterfaceUsingReflection()
        {
            TestStruct(typeof(StructWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedInterfaceUsingReflection()
        {
            TestStruct(typeof(StructWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestStructWithPublicNestedInterfaceUsingReflection()
        {
            TestStruct(typeof(StructWithPublicNestedInterface));
        }
    }
}
