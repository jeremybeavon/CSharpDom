using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_NestedInterfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedInternalNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicNestedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedInterface));
        }
    }
}
