using eAgenda.Dominio.TarefaModule;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using eAgenda.Controladores.TarefaModule;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eAgenda.ExportPDF
{
    public class ExportarPDF
    {
        /// <summary>
        /// Realiza a exportação para PDF das tarefas concluídas
        /// </summary>
        public static void ExportarTarefaEmPDF()
        {
            ControladorTarefa controlador = new ControladorTarefa();
            List<Tarefa> todasTarefas = controlador.SelecionarTodasTarefasConcluidas();
            
            using (PdfWriter wPdf = new PdfWriter($@"..\..\..\Relatorios\relatorioTarefaConcluida.pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                Document document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("Relatório Tarefas Concluídas").SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(20));

                foreach (var tarefa in todasTarefas)
                {
                    AdicionarTarefaNoDocumento(document, tarefa);
                }

                document.Close();

                pdfDocument.Close();
            }
            
        }

        /// <summary>
        /// Método privado chamado pelos métodos de exportação do pdf de Tarefas
        /// </summary>
        /// <param name="document">Documento criado</param>
        /// <param name="tarefa">Tarefa selecionada</param>
        private static void AdicionarTarefaNoDocumento(Document document, Tarefa tarefa)
        {
            document.Add(new Paragraph("\n\n"));
            document.Add(new Paragraph("Título da Tarefa: " + tarefa.Titulo.ToString()));
            document.Add(new Paragraph("Prioridade: " + tarefa.Prioridade.ToString()));
            document.Add(new Paragraph("Porcentagem de Conclusão: " + tarefa.Percentual.ToString() + "%"));
            document.Add(new Paragraph("Data de Criação da Tarefa: " + tarefa.DataCriacao.ToString("d")));
            document.Add(new Paragraph("Data de Conclusão: " + tarefa.DataConclusao.ToString()));

        }

        /// <summary>
        /// Realiza a exportação das tarefas pendentes para PDF
        /// </summary>
        public static void ExportarTarefaPendenteEmPDF()
        {
            ControladorTarefa controlador = new ControladorTarefa();
            List<Tarefa> todasTarefas = controlador.SelecionarTodasTarefasPendentes();

            using (PdfWriter wPdf = new PdfWriter($@"..\..\..\Relatorios\relatorioTarefaPendente.pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                Document document = new Document(pdfDocument, PageSize.A4);

                document.Add(new Paragraph("Relatório Tarefas Pendentes").SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(20));


                foreach (var tarefa in todasTarefas)
                {
                    AdicionarTarefaNoDocumento(document, tarefa);
                }

                document.Close();

                pdfDocument.Close();
            }

        }
    }
}
