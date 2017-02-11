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
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualMethod));
        }
    }
}
