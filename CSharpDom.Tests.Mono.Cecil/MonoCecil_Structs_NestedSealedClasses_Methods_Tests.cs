using CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverrideMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticMethod));
        }
    }
}
