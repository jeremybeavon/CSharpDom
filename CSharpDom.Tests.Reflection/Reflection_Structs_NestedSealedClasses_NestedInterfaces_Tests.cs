using CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_NestedInterfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicNestedInterface));
        }
    }
}
