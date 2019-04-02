#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"setQBitValue\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desiredValue\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qBit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":52}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"setQBitValue\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MFA\",\"Name\":\"QMain\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numberOfVertices\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"edgesPairS\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"edgesPairD\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":66}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numberOfEdges\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":86}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"MFA\",\"Name\":\"QMain\"},\"SourceFile\":\"/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing%20-%20Di%20Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
#line hidden
namespace MFA
{
    public class setQBitValue : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public setQBitValue(IOperationFactory m) : base(m)
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

        String ICallable.Name => "setQBitValue";
        String ICallable.FullName => "MFA.setQBitValue";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in__) =>
        {
            var (desiredValue,qBit) = __in__;
#line 7 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
            if ((desiredValue != Result.Zero))
            {
#line 9 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
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
            return __m__.Run<setQBitValue, (Result,Qubit), QVoid>((desiredValue, qBit));
        }
    }

    public class QMain : Operation<(Int64,QArray<Int64>,QArray<Int64>,Int64), QArray<Result>>, ICallable
    {
        public QMain(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Int64>,QArray<Int64>,Int64)>, IApplyData
        {
            public In((Int64,QArray<Int64>,QArray<Int64>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "QMain";
        String ICallable.FullName => "MFA.QMain";
        protected ICallable<(Result,Qubit), QVoid> setQBitValue
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

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Int64>,QArray<Int64>,Int64), QArray<Result>> Body => (__in__) =>
        {
            var (numberOfVertices,edgesPairS,edgesPairD,numberOfEdges) = __in__;
#line 19 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
            var returnval = new QArray<Result>(numberOfVertices);
#line hidden
            {
#line 21 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
                var edges = Allocate.Apply(numberOfEdges);
#line 24 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
                var source = 0L;
#line 25 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
                var sink = (numberOfVertices - 1L);
#line 30 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
                foreach (var i in new Range(0L, (numberOfEdges - 1L)))
#line hidden
                {
#line 32 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
                    setQBitValue.Apply((Result.Zero, edges[i]));
#line 33 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
                    MicrosoftQuantumPrimitiveH.Apply(edges[i]);
#line 34 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
                    var start = edgesPairS[i];
#line 35 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
                    var end = edgesPairD[i];
                }

#line 38 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
                foreach (var i in new Range(0L, (numberOfEdges - 1L)))
#line hidden
                {
#line 40 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
                    returnval[i] = M.Apply(edges[i]);
                }

#line hidden
                Release.Apply(edges);
            }

#line 44 "/mnt/F85CD2E95CD2A1A4/Users/Moreno/Documents/Politecnico/QuantumComputing - Di Nitto/quantum_research/Maximum_Flow_Analysis/MFA/MFA.qs"
            return returnval;
        }

        ;
        public override void Init()
        {
            this.setQBitValue = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(setQBitValue));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>,QArray<Int64>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Result> data) => data;
        public static System.Threading.Tasks.Task<QArray<Result>> Run(IOperationFactory __m__, Int64 numberOfVertices, QArray<Int64> edgesPairS, QArray<Int64> edgesPairD, Int64 numberOfEdges)
        {
            return __m__.Run<QMain, (Int64,QArray<Int64>,QArray<Int64>,Int64), QArray<Result>>((numberOfVertices, edgesPairS, edgesPairD, numberOfEdges));
        }
    }
}