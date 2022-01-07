using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeiroProjeto.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.NET.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 10;
            var b = 15;
            var esperado = 25;
            var contas = new Contas();

            var resultado = contas.Soma(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            var a = 3;
            var b = 2;
            var esperado = 1;
            var contas = new Contas();

            var resultado = contas.Subtracao(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            var a = 7;
            var b = 7;
            var esperado = 49;
            var contas = new Contas();

            var resultado = contas.Multiplicacao(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            var a = 100;
            var b = 5;
            var esperado = 20;
            var contas = new Contas();

            var resultado = contas.Divisao(a, b);

            Assert.AreEqual(esperado, resultado);
        }
    }
}