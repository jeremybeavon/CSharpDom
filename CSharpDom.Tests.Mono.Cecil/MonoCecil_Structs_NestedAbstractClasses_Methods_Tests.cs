using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualMethod));
        }
    }
}
