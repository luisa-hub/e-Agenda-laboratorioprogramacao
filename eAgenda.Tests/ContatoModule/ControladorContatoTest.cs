﻿using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace eAgenda.Tests.ContatoModule
{
    [TestClass]
    public class ControladorContatoTest
    {
        ControladorContato controlador = null;

        public ControladorContatoTest()
        {
            controlador = new ControladorContato();
            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");
        }

        [TestMethod]
        public void DeveInserir_Contato()
        {
            //arrange
            var novoContato = new Contato("José Pedro", "jose.pedro@gmail.com", "321654987", "JP Ltda", "Dev");

            //action
            controlador.InserirNovo(novoContato);

            //assert
            var contatoEncontrado = controlador.SelecionarPorId(novoContato.Id);
            contatoEncontrado.Should().Be(novoContato);
        }

        [TestMethod]
        public void DeveAtualizar_Contato()
        {
            //arrange
            var contato = new Contato("José Pedro", "jose.pedro@gmail.com", "321654987", "JP Ltda", "Dev");
            controlador.InserirNovo(contato);

            var novoContato = new Contato("Arnaldo Antunes", "arnaldo@gmail.com", "987654321", "Arn Ltda", "Musico");

            //action
            controlador.Editar(contato.Id, novoContato);

            //assert
            Contato contatoAtualizado = controlador.SelecionarPorId(contato.Id);
            contatoAtualizado.Should().Be(novoContato);
        }

        [TestMethod]
        public void DeveExcluir_Contato()
        {
            //arrange            
            var contato = new Contato("José Pedro", "jose.pedro@gmail.com", "321654987", "JP Ltda", "Dev");
            controlador.InserirNovo(contato);

            //action            
            controlador.Excluir(contato.Id);

            //assert
            Contato contatoEncontrado = controlador.SelecionarPorId(contato.Id);
            contatoEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_Contato_PorId()
        {
            //arrange
            var contato = new Contato("José Pedro", "jose.pedro@gmail.com", "321654987", "JP Ltda", "Dev");
            controlador.InserirNovo(contato);

            //action
            Contato contatoEncontrado = controlador.SelecionarPorId(contato.Id);

            //assert
            contatoEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosContatos()
        {
            //arrange
            var c1 = new Contato("José Pedro", "jose.pedro@gmail.com", "321654987", "JP Ltda", "Dev");
            controlador.InserirNovo(c1);

            var c2 = new Contato("Arnaldo Antuenes", "arnaldo@gmail.com", "987654321", "ARN Ltda", "Musico");
            controlador.InserirNovo(c2);

            var c3 = new Contato("Roberto Carlos", "roberto@gmail.com", "654987321", "RC Ltda", "Musico");
            controlador.InserirNovo(c3);

            //action
            var contatos = controlador.SelecionarTodos();

            //assert
            contatos.Should().HaveCount(3);
            contatos[0].Nome.Should().Be("José Pedro");
            contatos[1].Nome.Should().Be("Arnaldo Antuenes");
            contatos[2].Nome.Should().Be("Roberto Carlos");
        }
                

             
    }
}
