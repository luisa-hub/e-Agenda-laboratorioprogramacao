using eAgenda.Dominio.CompromissoModule;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using eAgenda.Controladores.CompromissoModule;

namespace eAgenda.ExportPDF
{
    /// <summary>
    /// Classe responsável pela exportação em PDF dos compromissos
    /// </summary>
    public class ExportarPDFCompromisso
    {
       
        /// <summary>
        /// Exportar todos os compromissos para PDF
        /// </summary>
        public static void ExportarCompromissosPDF()
        {
            ControladorCompromisso controlador = new ControladorCompromisso();
            List<Compromisso> todosCompromissos = controlador.SelecionarTodos();            

            using (PdfWriter wPdf = new PdfWriter($@"..\..\..\Relatorios\relatorioTodosCompromissos.pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                Document document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("Relatório de Todos os Compromissos").SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(20));

                foreach (var compromisso in todosCompromissos)
                {
                    AdicionarCompromissoNoDocumento(document, compromisso);
                }

                document.Close();

                pdfDocument.Close();
            }

        }

        /// <summary>
        /// Método responsável pela exportação dos PDFs dos compromissos passados, a partir de uma data
        /// </summary>
        /// <param name="data">Data do passado</param>
        public static void ExportarCompromissosPassadosPDF(DateTime data)
        {
            ControladorCompromisso controlador = new ControladorCompromisso();
            List<Compromisso> todosCompromissos = controlador.SelecionarCompromissosPassados(data);

            using (PdfWriter wPdf = new PdfWriter($@"..\..\..\Relatorios\relatorioCompromissosPassados.pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                Document document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("Relatório de Compromissos Passados").SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(20));

                foreach (var compromisso in todosCompromissos)
                {
                    AdicionarCompromissoNoDocumento(document, compromisso);
                }

                document.Close();

                pdfDocument.Close();
            }

        }

        /// <summary>
        /// Método responsável pela exportação do PDF de compromissos futuros, com base numa data de início e fim
        /// </summary>
        /// <param name="dataInicio">Data de Início</param>
        /// <param name="dataFim">Data Fim</param>
        public static void ExportarCompromissosFuturosPDF(DateTime dataInicio, DateTime dataFim)
        {
            ControladorCompromisso controlador = new ControladorCompromisso();
            List<Compromisso> todosCompromissos = controlador.SelecionarCompromissosFuturos(dataInicio, dataFim);

            using (PdfWriter wPdf = new PdfWriter($@"..\..\..\Relatorios\relatorioCompromissosFuturos.pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                Document document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("Relatório de Compromissos Futuros").SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(20));

                foreach (var compromisso in todosCompromissos)
                {
                    AdicionarCompromissoNoDocumento(document, compromisso);
                }

                document.Close();

                pdfDocument.Close();
            }

        }

        /// <summary>
        /// Método privado que adiciona um compromisso ao documento
        /// </summary>
        /// <param name="document">Documento do Compromisso</param>
        /// <param name="compromisso">Compromisso a ser adicionado</param>
        private static void AdicionarCompromissoNoDocumento(Document document, Compromisso compromisso)
        {
            document.Add(new Paragraph("\n\n"));
            document.Add(new Paragraph("Assunto: " + compromisso.Assunto.ToString()));
            document.Add(new Paragraph("Contato: " + compromisso.Contato.Nome.ToString()));

            if (!String.IsNullOrEmpty(compromisso.Local))
                document.Add(new Paragraph("Local: " + compromisso.Local.ToString()));

            if(!String.IsNullOrEmpty(compromisso.Link))
                document.Add(new Paragraph("Link: " + compromisso.Link.ToString()));

            document.Add(new Paragraph("Data: " + compromisso.Data.ToString("d")));
            document.Add(new Paragraph("Hora Início: " + compromisso.HoraInicio.ToString()));
            document.Add(new Paragraph("Hora Término: " + compromisso.HoraTermino.ToString()));
            
        }

    }
}
