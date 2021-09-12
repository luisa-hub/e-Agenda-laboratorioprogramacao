using eAgenda.Dominio.Shared;
using System;
using System.Collections.Generic;

namespace eAgenda.Dominio.TarefaModule
{
    /// <summary>
    /// Classe de criação do registro tarefa, que herda de EntidadeBase e implementa IEquetable
    /// </summary>
    public class Tarefa : EntidadeBase, IEquatable<Tarefa>
    {        
        /// <summary>
        /// Construtor da Tarefa
        /// </summary>
        /// <param name="titulo">Título da Tarefa</param>
        /// <param name="dataCriacao">Data de Criação da Tarefa</param>
        /// <param name="prioridade">Prioridade da Tarefa</param>
        public Tarefa(string titulo, DateTime dataCriacao, PrioridadeEnum prioridade)
        {            
            Titulo = titulo;
            DataCriacao = dataCriacao.Date;
            Prioridade = new Prioridade(prioridade);            
        }


        public string Titulo { get; set; }

        public Prioridade Prioridade { get; set; }

        public DateTime DataCriacao { get; set; }

        public int Percentual { get; set; }

        public DateTime? DataConclusao { get; set; }        

        /// <summary>
        /// Atualizar percentual da tarefa
        /// </summary>
        /// <param name="percentual">novo percentual</param>
        /// <param name="dataConclusao">Recebe data de conclusão e atualiza caso seja 100%</param>
        public string AtualizarPercentual(int percentual, DateTime dataConclusao)
        {
            
            if(percentual < 0 || percentual > 100)
            {
                
                return "A porcentagem precisa ser entre 0 e 100";
            }

            Percentual = percentual;

            if (Percentual == 100)
            {
                DataConclusao = dataConclusao;
            }

            return "";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Tarefa);
        }

        public bool Equals(Tarefa other)
        {
            return other != null &&
                   Id == other.Id &&
                   Titulo == other.Titulo &&
                   DataConclusao == other.DataConclusao &&
                   Percentual == other.Percentual &&
                   EqualityComparer<Prioridade>.Default.Equals(Prioridade, other.Prioridade) &&
                   DataCriacao == other.DataCriacao;
        }

        public override int GetHashCode()
        {
            int hashCode = -1307587567;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Titulo);
            hashCode = hashCode * -1521134295 + DataConclusao.GetHashCode();
            hashCode = hashCode * -1521134295 + Percentual.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Prioridade>.Default.GetHashCode(Prioridade);
            hashCode = hashCode * -1521134295 + DataCriacao.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Valida os campos da tarefa
        /// </summary>
        /// <returns>Retorna uma string de validação</returns>
        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Titulo))            
                resultadoValidacao = "O campo Título é obrigatório";

            if (DataCriacao == DateTime.MinValue)           
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Data de Criação é obrigatório";
            
            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }



    }
}