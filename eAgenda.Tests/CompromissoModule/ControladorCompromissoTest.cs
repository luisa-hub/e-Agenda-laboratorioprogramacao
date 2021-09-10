using System;

using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class ControladorCompromissoTest
    {

        ControladorCompromisso controlador = null;
        

        public ControladorCompromissoTest()
        {
            controlador = new ControladorCompromisso();
            
            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");

        }

        [TestMethod]
        public void DeveInserir_Compromisso()
        {
            //arrange
           
            Compromisso novoCompromisso = new Compromisso("tarefa laboratorio", "google classroom", "",
                new DateTime(2021, 12, 09), new TimeSpan(9, 9, 36), new TimeSpan(10, 10, 45), null );


            //action
            controlador.InserirNovo(novoCompromisso);

            //assert
            Compromisso compromissoEncontrado = controlador.SelecionarPorId(novoCompromisso.Id);
            compromissoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveInserir_CompromissoComContato()
        {
            ControladorContato controladorContato = new ControladorContato(); 

            //arrange
            Contato contato = new Contato("bom dia", "jose.pedro@gmail.com", "32164", "JP Ltda", "Desenvolvedor");
            controladorContato.InserirNovo(contato);

            
            Compromisso novoCompromisso = new Compromisso("tarefa laboratorio", "google classroom", "",
                new DateTime(2021, 12, 09), new TimeSpan(9, 9, 36), new TimeSpan(10, 10, 45), controladorContato.SelecionarPorId(contato.Id));


            //action
            controlador.InserirNovo(novoCompromisso);
            

            //assert
            Compromisso compromissoEncontrado = controlador.SelecionarPorId(novoCompromisso.Id);
            compromissoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveEditar_CompromissoComContato()
        {
            ControladorContato controladorContato = new ControladorContato();

            //arrange
            Contato contato = new Contato("bom dia", "jose.pedro@gmail.com", "32164", "JP Ltda", "Desenvolvedor");
            controladorContato.InserirNovo(contato);


            Compromisso novoCompromisso = new Compromisso("tarefa laboratorio", "google classroom", "",
                new DateTime(2021, 12, 09), new TimeSpan(9, 9, 36), new TimeSpan(10, 10, 45), controladorContato.SelecionarPorId(contato.Id));

            Compromisso compromissoEditado = new Compromisso("tarefa de compromissos", "google classroom", "",
               new DateTime(2021, 12, 09), new TimeSpan(9, 9, 36), new TimeSpan(10, 10, 45), controladorContato.SelecionarPorId(contato.Id));


            //action
            controlador.InserirNovo(novoCompromisso);
            controlador.Editar(controlador.SelecionarPorId(novoCompromisso.Id).Id, compromissoEditado);


            //assert
            Compromisso compromissoEncontrado = controlador.SelecionarPorId(compromissoEditado.Id);
            compromissoEncontrado.Should().Be(compromissoEditado);
        }

        [TestMethod]
        public void DeveExcluir_CompromissoComContato()
        {
            ControladorContato controladorContato = new ControladorContato();

            //arrange
            Contato contato = new Contato("bom dia", "jose.pedro@gmail.com", "32164", "JP Ltda", "Desenvolvedor");
            controladorContato.InserirNovo(contato);


            Compromisso novoCompromisso = new Compromisso("tarefa laboratorio", "google classroom", "",
                new DateTime(2021, 12, 09), new TimeSpan(9, 9, 36), new TimeSpan(10, 10, 45), controladorContato.SelecionarPorId(contato.Id));

           


            //action
            controlador.InserirNovo(novoCompromisso);
            bool excluir = controlador.Excluir(novoCompromisso.Id);


            //assert

            excluir.Should().Be(true);
        }
    }
}
