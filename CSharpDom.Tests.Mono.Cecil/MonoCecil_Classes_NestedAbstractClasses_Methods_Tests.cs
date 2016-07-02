using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverrideMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverrideMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualMethod));
        }
    }
}
