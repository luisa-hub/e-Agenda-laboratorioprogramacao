
using eAgenda.Dominio.CompromissoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class CompromissoTest
    {
        [TestMethod]
        public void DeveValidar_Campos()
        {
            Compromisso compromisso = new Compromisso("prova de laboratorio", "google classroom", null, 
                new DateTime(2021, 07, 01), new TimeSpan(0, 9, 25), new TimeSpan(0, 10, 30), null);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("ESTA_VALIDO");

        }

        [TestMethod]
        public void DeveValidar_Assunto()
        {
            Compromisso compromisso = new Compromisso(null, "igreja", null,
                new DateTime(2021, 07, 01), new TimeSpan(0, 9, 25), new TimeSpan(0, 10, 30), null);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Assunto é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_Data()
        {
           
            Compromisso compromisso = new Compromisso("Atividade Calculo", "sigaa", null,
                DateTime.MinValue, new TimeSpan(0, 9, 25), new TimeSpan(0, 10, 30), null);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Data é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_HoraInicio()
        {

            Compromisso compromisso = new Compromisso("Atividade Calculo", "sigaa", null,
               new DateTime(2021, 07, 01), TimeSpan.MinValue, new TimeSpan(0, 10, 30), null);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Hora Início é obrigatório");

        }

        [TestMethod]
        public void DeveValidar_HoraFim()
        {

            Compromisso compromisso = new Compromisso("Atividade Calculo", "sigaa", null,
               new DateTime(2021, 07, 01), new TimeSpan(0, 10, 30), TimeSpan.MinValue, null);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Hora Término é obrigatório");

        }
    }
}
