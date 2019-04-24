#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"initializeQBitValue\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desiredValue\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qBit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"initializeQBitValue\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"initializeQBitArray\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desiredValues\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qBits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":61}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"initializeQBitArray\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"oneHot2\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qb0\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qb1\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"oneHot2\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"oneHot\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qb\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":20}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"oneHot\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"QMain\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":101,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numberOfVertices\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"edgesPairS\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"edgesPairD\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":66}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"howManyArcsFromSource\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":94}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"howManyArcsToSink\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":102},\"Item2\":{\"Line\":1,\"Column\":119}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"QMain\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":101,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
#line hidden
namespace MFA
{
    public class initializeQBitValue : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public initializeQBitValue(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "initializeQBitValue";
        String ICallable.FullName => "MFA.initializeQBitValue";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in__) =>
        {
            var (desiredValue,qBit) = __in__;
#line 9 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
            if ((desiredValue != Result.Zero))
            {
#line 11 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                MicrosoftQuantumPrimitiveX.Apply(qBit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desiredValue, Qubit qBit)
        {
            return __m__.Run<initializeQBitValue, (Result,Qubit), QVoid>((desiredValue, qBit));
        }
    }

    public class initializeQBitArray : Operation<(QArray<Boolean>,QArray<Qubit>), QVoid>, ICallable
    {
        public initializeQBitArray(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Boolean>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Boolean>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "initializeQBitArray";
        String ICallable.FullName => "MFA.initializeQBitArray";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Boolean>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (desiredValues,qBits) = __in__;
#line 18 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
            var qBitsSize = qBits.Length;
#line 19 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
            var desiredValuesSize = desiredValues.Length;
#line 26 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
            if ((qBitsSize == 1L))
            {
#line 29 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                if ((desiredValues[0L] != false))
                {
#line 31 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qBits[0L]);
                }
                else
                {
                }
            }
            else
            {
#line 38 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                foreach (var i in new Range(0L, (qBitsSize - 1L)))
#line hidden
                {
#line 40 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    if ((desiredValues[i] != false))
                    {
#line 44 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                        MicrosoftQuantumPrimitiveX.Apply(qBits[i]);
                    }
                    else
                    {
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Boolean>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Boolean> desiredValues, QArray<Qubit> qBits)
        {
            return __m__.Run<initializeQBitArray, (QArray<Boolean>,QArray<Qubit>), QVoid>((desiredValues, qBits));
        }
    }

    public class oneHot2 : Operation<(Qubit,Qubit), QVoid>, ICallable
    {
        public oneHot2(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "oneHot2";
        String ICallable.FullName => "MFA.oneHot2";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (qb0,qb1) = __in__;
#line 55 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
            MicrosoftQuantumPrimitiveH.Apply(qb0);
#line 56 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
            MicrosoftQuantumPrimitiveX.Apply(qb1);
#line 57 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((qb0, qb1));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qb0, Qubit qb1)
        {
            return __m__.Run<oneHot2, (Qubit,Qubit), QVoid>((qb0, qb1));
        }
    }

    public class oneHot : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public oneHot(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "oneHot";
        String ICallable.FullName => "MFA.oneHot";
        protected ICallable<(QArray<Boolean>,QArray<Qubit>), QVoid> initializeQBitArray
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<System.Numerics.BigInteger, QArray<Boolean>> MicrosoftQuantumExtensionsConvertBigIntToBools
        {
            get;
            set;
        }

        protected ICallable<Int64, System.Numerics.BigInteger> MicrosoftQuantumExtensionsConvertToBigInt
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathCeiling
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathLog
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qb = __in__;
#line 75 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
            var qbSize = qb.Length;
#line 76 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
            var howManyExtraQubits = MicrosoftQuantumExtensionsMathCeiling.Apply((MicrosoftQuantumExtensionsMathLog.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(qbSize)) / MicrosoftQuantumExtensionsMathLog.Apply(2D)));
#line hidden
            {
#line 78 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                var extra = Allocate.Apply(howManyExtraQubits);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 80 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    foreach (var e in extra)
#line hidden
                    {
#line 82 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                        MicrosoftQuantumPrimitiveH.Apply(e);
                    }

#line 84 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    foreach (var i in new Range(0L, (qbSize - 1L)))
#line hidden
                    {
#line 86 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                        var boolArr = MicrosoftQuantumExtensionsConvertBigIntToBools.Apply(MicrosoftQuantumExtensionsConvertToBigInt.Apply(i));
#line 87 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                        initializeQBitArray.Apply((boolArr?.Copy(), extra?.Copy()));
#line 88 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                        MicrosoftQuantumPrimitiveX.Controlled.Apply((extra?.Copy(), qb[i]));
#line 89 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                        initializeQBitArray.Apply((boolArr?.Copy(), extra?.Copy()));
                    }

#line 94 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    foreach (var e in extra)
#line hidden
                    {
#line 96 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                        MicrosoftQuantumPrimitiveH.Apply(e);
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(extra);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.initializeQBitArray = this.Factory.Get<ICallable<(QArray<Boolean>,QArray<Qubit>), QVoid>>(typeof(initializeQBitArray));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertBigIntToBools = this.Factory.Get<ICallable<System.Numerics.BigInteger, QArray<Boolean>>>(typeof(Microsoft.Quantum.Extensions.Convert.BigIntToBools));
            this.MicrosoftQuantumExtensionsConvertToBigInt = this.Factory.Get<ICallable<Int64, System.Numerics.BigInteger>>(typeof(Microsoft.Quantum.Extensions.Convert.ToBigInt));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathCeiling = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Ceiling));
            this.MicrosoftQuantumExtensionsMathLog = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Log));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qb)
        {
            return __m__.Run<oneHot, QArray<Qubit>, QVoid>(qb);
        }
    }

    public class QMain : Operation<(Int64,QArray<Int64>,QArray<Int64>,Int64,Int64), QArray<Result>>, ICallable
    {
        public QMain(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Int64>,QArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((Int64,QArray<Int64>,QArray<Int64>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "QMain";
        String ICallable.FullName => "MFA.QMain";
        protected ICallable<(Result,Qubit), QVoid> initializeQBitValue
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> oneHot
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Int64>,QArray<Int64>,Int64,Int64), QArray<Result>> Body => (__in__) =>
        {
            var (numberOfVertices,edgesPairS,edgesPairD,howManyArcsFromSource,howManyArcsToSink) = __in__;
#line 104 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
            var numberOfEdges = edgesPairS.Length;
#line hidden
            {
#line 107 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                var edge = Allocate.Apply(numberOfEdges);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 109 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    var source = 0L;
#line 110 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    var sink = (numberOfVertices - 1L);
#line 111 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    var sourceSet = edge?.Slice(new Range(0L, (howManyArcsFromSource - 1L)));
#line 112 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    var sinkSet = edge?.Slice(new Range((howManyArcsToSink - 1L), (numberOfEdges - 1L)));
#line 113 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    foreach (var i in new Range(0L, (numberOfEdges - 1L)))
#line hidden
                    {
#line 115 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                        initializeQBitValue.Apply((Result.Zero, edge[i]));
#line 116 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                        var arcStart = edgesPairS[i];
#line 117 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                        var arcEnd = edgesPairD[i];
#line 118 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                        if (((arcStart == source) && (arcEnd == sink)))
                        {
                        }
                    }

#line 126 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    oneHot.Apply(sourceSet?.Copy());
#line 128 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    oneHot.Apply(sinkSet?.Copy());
#line 131 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA\\MFA.qs"
                    return MicrosoftQuantumCanonMultiM.Apply(edge?.Copy());
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(edge);
                }
            }
        }

        ;
        public override void Init()
        {
            this.initializeQBitValue = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(initializeQBitValue));
            this.oneHot = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(oneHot));
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>,QArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Result> data) => data;
        public static System.Threading.Tasks.Task<QArray<Result>> Run(IOperationFactory __m__, Int64 numberOfVertices, QArray<Int64> edgesPairS, QArray<Int64> edgesPairD, Int64 howManyArcsFromSource, Int64 howManyArcsToSink)
        {
            return __m__.Run<QMain, (Int64,QArray<Int64>,QArray<Int64>,Int64,Int64), QArray<Result>>((numberOfVertices, edgesPairS, edgesPairD, howManyArcsFromSource, howManyArcsToSink));
        }
    }
}