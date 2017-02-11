using CSharpDom.TestTarget.Structs.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualMethod));
        }
    }
}
