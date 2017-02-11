using CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticMethod));
        }
    }
}
