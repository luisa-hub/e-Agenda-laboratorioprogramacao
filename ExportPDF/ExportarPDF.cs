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
        public static void ExportarTarefaEmPDF()
        {
            ControladorTarefa controlador = new ControladorTarefa();
            List<Tarefa> todasTarefas = controlador.SelecionarTodasTarefasConcluidas();
            
            using (PdfWriter wPdf = new PdfWriter($@"..\..\..\Relatorios\relatorioTarefa.pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                Document document = new Document(pdfDocument, PageSize.A4);

                foreach (var tarefa in todasTarefas)
                {
                    document.Add(new Paragraph("Relatório Tarefas Concluídas").SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(20));
                    document.Add(new Paragraph("\n\n"));
                    document.Add(new Paragraph("Título da Tarefa: " + tarefa.Titulo.ToString()));
                    document.Add(new Paragraph("Prioridade: " + tarefa.Prioridade.ToString()));
                    document.Add(new Paragraph("Procentagem de Conclusão: " + tarefa.Percentual.ToString() + "%"));
                    document.Add(new Paragraph("Data de Criação da Tarefa: " + tarefa.DataCriacao.ToString("d")));
                    document.Add(new Paragraph("Data de Conclusão: " + tarefa.DataConclusao.ToString()));

                    document.Add(new Paragraph("\n\n"));
                }
                
                document.Close();

                pdfDocument.Close();
            }
            
        }
    }
}
