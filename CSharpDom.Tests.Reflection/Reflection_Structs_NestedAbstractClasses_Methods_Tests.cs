using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualMethod));
        }
    }
}
