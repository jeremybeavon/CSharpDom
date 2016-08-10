using CSharpDom.TestTarget.Structs.NestedStructs.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_NestedInterfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicNestedInterface));
        }
    }
}
