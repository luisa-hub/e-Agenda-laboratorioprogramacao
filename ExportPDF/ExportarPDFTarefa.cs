using eAgenda.Dominio.TarefaModule;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Collections.Generic;
using eAgenda.Controladores.TarefaModule;
using System.Threading;

namespace eAgenda.ExportPDF
{
    /// <summary>
    /// Classe responsável pela exportação dos PDFs das tarefas concluídas e pendentes
    /// </summary>
    public class ExportarPDFTarefa
    {
        static bool english = Thread.CurrentThread.CurrentUICulture.ToString() == "en-US";
        /// <summary>
        /// Realiza a exportação para PDF das tarefas concluídas
        /// </summary>
        public static void ExportarTarefaEmPDF()
        {
            ControladorTarefa controlador = new ControladorTarefa();
            List<Tarefa> todasTarefas = controlador.SelecionarTodasTarefasConcluidas();
            string url;
            string strParagraph;
            if (english)
            {
                url = $@"..\..\..\Reports\completedTasksReport.pdf";
                strParagraph = "Completed Tasks Report";
            }
            else
            {
                url = $@"..\..\..\Relatorios\relatorioTarefaConcluida.pdf";
                strParagraph = "Relatório Tarefas Concluídas";
            }
            using (PdfWriter wPdf = new PdfWriter(url, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                Document document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph(strParagraph).SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(20));

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
            if (english) {
                document.Add(new Paragraph("\n\n"));
                document.Add(new Paragraph("Task Title: " + tarefa.Titulo.ToString()));
                document.Add(new Paragraph("Priority: " + tarefa.Prioridade.ToString()));
                document.Add(new Paragraph("Completion Percentage: " + tarefa.Percentual.ToString() + "%"));
                document.Add(new Paragraph("Task Creation Date: " + tarefa.DataCriacao.ToString("d")));
                document.Add(new Paragraph("Completion Date: " + tarefa.DataConclusao.ToString()));
            }
            else
            {
                document.Add(new Paragraph("\n\n"));
                document.Add(new Paragraph("Título da Tarefa: " + tarefa.Titulo.ToString()));
                document.Add(new Paragraph("Prioridade: " + tarefa.Prioridade.ToString()));
                document.Add(new Paragraph("Porcentagem de Conclusão: " + tarefa.Percentual.ToString() + "%"));
                document.Add(new Paragraph("Data de Criação da Tarefa: " + tarefa.DataCriacao.ToString("d")));
                document.Add(new Paragraph("Data de Conclusão: " + tarefa.DataConclusao.ToString()));
            }
        }

        /// <summary>
        /// Realiza a exportação das tarefas pendentes para PDF
        /// </summary>
        public static void ExportarTarefaPendenteEmPDF()
        {
            ControladorTarefa controlador = new ControladorTarefa();
            List<Tarefa> todasTarefas = controlador.SelecionarTodasTarefasPendentes();
            string url;
            string strParagraph;
            if (english)
            {
                url = $@"..\..\..\Reports\pendingTasksReport.pdf";
                strParagraph = "Pending Tasks Report";
            }
            else
            {
                url = $@"..\..\..\Relatorios\relatorioTarefaPendente.pdf";
                strParagraph = "Relatório Tarefas Pendentes";
            }
            using (PdfWriter wPdf = new PdfWriter(url, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                Document document = new Document(pdfDocument, PageSize.A4);

                document.Add(new Paragraph(strParagraph).SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(20));


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
