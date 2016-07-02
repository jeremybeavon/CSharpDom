using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_NestedSealedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWithBaseClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedInternalNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedSealedClass));
        }
    }
}
