using CSharpDom.TestTarget.Structs.NestedClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_NestedInterfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicNestedInterface));
        }
    }
}
